using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace DiGi.Python
{
    public static partial class Modify
    {
        /// <summary>
        /// Writes Python scripts and their companion files, shipped inside an assembly, into a directory.
        /// <para>A file is taken from the folder <paramref name="sourceDirectoryName"/> beside <paramref name="assembly"/> when it is there, which lets a script be edited in a build output and tried without rebuilding; otherwise from the embedded resource named <paramref name="resourcePrefix"/> followed by the file name.</para>
        /// <para>Files are always rewritten, so a directory never keeps running a script of an older build. The names in <paramref name="fileNames_KeepExisting"/> are the exception: they are data rather than scripts (a template configuration file, for example), so they are written only when the directory has none and never replace one written there by other means.</para>
        /// <para>A script importing a sibling module is resolved by Python against the directory the script sits in, so files that import each other are only useful written together.</para>
        /// </summary>
        /// <param name="assembly">The assembly holding the embedded resources, and beside which the source folder is looked for.</param>
        /// <param name="resourcePrefix">The prefix of the embedded resource names, typically the default namespace and folder followed by a dot (e.g. "DiGi.YOLO.YOLO.").</param>
        /// <param name="sourceDirectoryName">The name of the folder beside the assembly that is preferred over the embedded resources.</param>
        /// <param name="fileNames">The names of the files to write.</param>
        /// <param name="directory">The directory to write the files into, created when missing.</param>
        /// <param name="fileNames_KeepExisting">The names of the files written only when the directory has none (compared case-insensitively), or <c>null</c>.</param>
        /// <returns>True if every file was written or kept; otherwise, false.</returns>
        public static bool WriteScripts(Assembly assembly, string resourcePrefix, string sourceDirectoryName, IEnumerable<string> fileNames, string? directory, IEnumerable<string>? fileNames_KeepExisting = null)
        {
            if (assembly == null || fileNames == null || string.IsNullOrWhiteSpace(directory))
            {
                return false;
            }

            string? assemblyDirectory = string.IsNullOrWhiteSpace(assembly.Location) ? null : Path.GetDirectoryName(assembly.Location);
            if (string.IsNullOrWhiteSpace(assemblyDirectory))
            {
                assemblyDirectory = AppDomain.CurrentDomain.BaseDirectory;
            }

            string? directory_Source = string.IsNullOrWhiteSpace(sourceDirectoryName) ? null : Path.Combine(assemblyDirectory, sourceDirectoryName);

            HashSet<string> fileNames_Keep = new(StringComparer.OrdinalIgnoreCase);
            if (fileNames_KeepExisting != null)
            {
                foreach (string fileName in fileNames_KeepExisting)
                {
                    if (!string.IsNullOrWhiteSpace(fileName))
                    {
                        fileNames_Keep.Add(fileName);
                    }
                }
            }

            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            bool result = true;

            foreach (string fileName in fileNames)
            {
                if (string.IsNullOrWhiteSpace(fileName))
                {
                    result = false;
                    continue;
                }

                string path_Target = Path.Combine(directory, fileName);

                if (fileNames_Keep.Contains(fileName) && File.Exists(path_Target))
                {
                    continue;
                }

                if (directory_Source != null)
                {
                    string path_Source = Path.Combine(directory_Source, fileName);
                    if (File.Exists(path_Source))
                    {
                        File.Copy(path_Source, path_Target, true);
                        continue;
                    }
                }

                using Stream? stream = assembly.GetManifestResourceStream(string.Concat(resourcePrefix, fileName));
                if (stream == null)
                {
                    result = false;
                    continue;
                }

                using FileStream fileStream = File.Create(path_Target);
                stream.CopyTo(fileStream);
            }

            return result;
        }
    }
}
