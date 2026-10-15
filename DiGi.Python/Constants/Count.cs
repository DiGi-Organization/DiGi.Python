namespace DiGi.Python.Constants
{
    /// <summary>
    /// Provides constant counts used to bound the data collected while running a Python process.
    /// </summary>
    public static class Count
    {
        /// <summary>
        /// The number of trailing lines kept from each of the output streams of a process run by <see cref="Query.ExecuteProcess(string, string, string, System.Collections.Generic.Dictionary{string, string}?, System.TimeSpan?, System.Threading.CancellationToken)"/>.
        /// <para>A long running script, together with the libraries it uses, can write megabytes to its output streams. Only the tail is kept, because that is the part carrying the reason a run ended the way it did.</para>
        /// </summary>
        public const int OutputLines = 200;
    }
}
