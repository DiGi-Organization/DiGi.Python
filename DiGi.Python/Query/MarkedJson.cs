using System.Collections.Generic;

namespace DiGi.Python
{
    public static partial class Query
    {
        /// <summary>
        /// Finds the JSON payload a script prints between a pair of marker lines in its captured standard output.
        /// <para>The payload is taken from the <b>last</b> begin marker: the non-blank lines between it and the first end marker after it, trimmed and joined with a line feed. Whatever the interpreter or the libraries print before or after the pair - a settings notice included - therefore never reaches the payload, and a script that reports twice is read by its final report.</para>
        /// <para>Marker lines are compared after trimming, ordinally. The payload is returned as text; parsing it stays with the caller.</para>
        /// </summary>
        /// <param name="lines">The captured standard output lines of the run.</param>
        /// <param name="beginMarker">The marker line the script prints immediately before its JSON payload.</param>
        /// <param name="endMarker">The marker line the script prints immediately after its JSON payload.</param>
        /// <returns>The JSON payload text, or <c>null</c> when <paramref name="lines"/> is <c>null</c>, either marker is missing, no end marker follows the last begin marker, or nothing but blank lines lies between them.</returns>
        public static string? MarkedJson(IEnumerable<string>? lines, string beginMarker, string endMarker)
        {
            if (lines == null || string.IsNullOrWhiteSpace(beginMarker) || string.IsNullOrWhiteSpace(endMarker))
            {
                return null;
            }

            List<string> lines_Trimmed = [];
            foreach (string? line in lines)
            {
                lines_Trimmed.Add(line == null ? string.Empty : line.Trim());
            }

            string beginMarker_Trimmed = beginMarker.Trim();
            string endMarker_Trimmed = endMarker.Trim();

            int index_Begin = lines_Trimmed.LastIndexOf(beginMarker_Trimmed);
            if (index_Begin < 0)
            {
                return null;
            }

            List<string> values = [];
            for (int i = index_Begin + 1; i < lines_Trimmed.Count; i++)
            {
                string line = lines_Trimmed[i];
                if (line == endMarker_Trimmed)
                {
                    return values.Count == 0 ? null : string.Join("\n", values);
                }

                if (line.Length != 0)
                {
                    values.Add(line);
                }
            }

            return null;
        }
    }
}
