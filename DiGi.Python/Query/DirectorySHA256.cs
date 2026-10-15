using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace DiGi.Python
{
    public static partial class Query
    {
        /// <summary>
        /// Computes a deterministic SHA-256 digest of the files in a directory and its subdirectories, as lowercase hexadecimal - used to identify a model or checkpoint folder by its content.
        /// <para>Each file contributes its path relative to <paramref name="directory"/>, written with "/" separators, a line feed, its <see cref="FileSHA256(string?)"/> digest and a line feed. The files are ordered by that relative path (ordinal), and the digest is taken over the UTF-8 bytes of the result, so it does not depend on the order the file system enumerates them in or on the platform's directory separator.</para>
        /// <para>The directory name itself is not part of the digest: the same content copied elsewhere hashes the same. A file matched by several of <paramref name="searchPatterns"/> is counted once. An empty directory hashes the empty input.</para>
        /// </summary>
        /// <param name="directory">The directory to hash.</param>
        /// <param name="searchPatterns">The file name patterns of the files to include, such as "*.safetensors", or <c>null</c> to include every file.</param>
        /// <returns>The 64-character lowercase hexadecimal digest, or <c>null</c> when the directory is empty or missing as a path, does not exist, or one of its files cannot be read.</returns>
        public static string? DirectorySHA256(string? directory, IEnumerable<string>? searchPatterns = null)
        {
            string? directory_Normalized = NormalizedPath(directory);
            if (directory_Normalized == null || !Directory.Exists(directory_Normalized))
            {
                return null;
            }

            static string Hex(byte[] bytes)
            {
                StringBuilder stringBuilder = new(bytes.Length * 2);
                foreach (byte @byte in bytes)
                {
                    stringBuilder.Append(@byte.ToString("x2", CultureInfo.InvariantCulture));
                }

                return stringBuilder.ToString();
            }

            List<string> searchPatterns_Effective = [];
            if (searchPatterns != null)
            {
                foreach (string searchPattern in searchPatterns)
                {
                    if (!string.IsNullOrWhiteSpace(searchPattern))
                    {
                        searchPatterns_Effective.Add(searchPattern);
                    }
                }
            }

            if (searchPatterns_Effective.Count == 0)
            {
                searchPatterns_Effective.Add("*");
            }

            //A root such as "C:\" keeps its separator after normalization, any other directory does not
            string prefix = directory_Normalized.EndsWith(Path.DirectorySeparatorChar.ToString(), StringComparison.Ordinal) || directory_Normalized.EndsWith(Path.AltDirectorySeparatorChar.ToString(), StringComparison.Ordinal)
                ? directory_Normalized
                : directory_Normalized + Path.DirectorySeparatorChar;

            HashSet<string> paths_Seen = new(StringComparer.OrdinalIgnoreCase);
            List<KeyValuePair<string, string>> relativePaths = [];

            try
            {
                foreach (string searchPattern in searchPatterns_Effective)
                {
                    foreach (string path in Directory.EnumerateFiles(directory_Normalized, searchPattern, SearchOption.AllDirectories))
                    {
                        string path_Full = Path.GetFullPath(path);
                        if (!paths_Seen.Add(path_Full) || !path_Full.StartsWith(prefix, StringComparison.OrdinalIgnoreCase))
                        {
                            continue;
                        }

                        string relativePath = path_Full.Substring(prefix.Length).Replace(Path.DirectorySeparatorChar, '/').Replace(Path.AltDirectorySeparatorChar, '/');
                        relativePaths.Add(new KeyValuePair<string, string>(relativePath, path_Full));
                    }
                }
            }
            catch (IOException)
            {
                return null;
            }
            catch (UnauthorizedAccessException)
            {
                return null;
            }

            relativePaths.Sort((keyValuePair_1, keyValuePair_2) => string.CompareOrdinal(keyValuePair_1.Key, keyValuePair_2.Key));

            StringBuilder stringBuilder_Manifest = new();
            foreach (KeyValuePair<string, string> keyValuePair in relativePaths)
            {
                string? sHA256 = FileSHA256(keyValuePair.Value);
                if (sHA256 == null)
                {
                    return null;
                }

                stringBuilder_Manifest.Append(keyValuePair.Key).Append('\n').Append(sHA256).Append('\n');
            }

            using SHA256 sHA256_Manifest = SHA256.Create();
            return Hex(sHA256_Manifest.ComputeHash(Encoding.UTF8.GetBytes(stringBuilder_Manifest.ToString())));
        }
    }
}
