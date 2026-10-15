using DiGi.Core.Classes;
using DiGi.Python.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Python.Classes
{
    /// <summary>
    /// Represents the outcome of a process run by <see cref="Query.ExecuteProcess(string, string, string, Dictionary{string, string}?, System.TimeSpan?, System.Threading.CancellationToken)"/>.
    /// <para>Only the last <see cref="Constants.Count.OutputLines"/> lines of each output stream are kept, because that is the part carrying the reason a run ended the way it did.</para>
    /// </summary>
    public class PythonProcessResult : SerializableResult, IPythonSerializableObject
    {
        [JsonInclude, JsonPropertyName(nameof(Cancelled))]
        private readonly bool cancelled;

        [JsonInclude, JsonPropertyName(nameof(ExitCode))]
        private readonly int exitCode;

        [JsonInclude, JsonPropertyName(nameof(Stalled))]
        private readonly bool stalled;

        [JsonInclude, JsonPropertyName(nameof(StandardError))]
        private readonly List<string>? standardError;

        [JsonInclude, JsonPropertyName(nameof(StandardOutput))]
        private readonly List<string>? standardOutput;

        /// <summary>
        /// Initializes a new instance of the <see cref="PythonProcessResult"/> class.
        /// </summary>
        /// <param name="exitCode">The exit code of the process, or -1 when it was cancelled, ended for inactivity or failed to start.</param>
        /// <param name="standardOutput">The trailing standard output lines of the process.</param>
        /// <param name="standardError">The trailing standard error lines of the process.</param>
        /// <param name="stalled">A value indicating whether the process was ended because it stopped producing output.</param>
        /// <param name="cancelled">A value indicating whether the process was ended because the run was cancelled.</param>
        public PythonProcessResult(int exitCode, IEnumerable<string>? standardOutput, IEnumerable<string>? standardError, bool stalled, bool cancelled)
        {
            this.exitCode = exitCode;
            this.standardOutput = standardOutput == null ? null : [.. standardOutput];
            this.standardError = standardError == null ? null : [.. standardError];
            this.stalled = stalled;
            this.cancelled = cancelled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PythonProcessResult"/> class by copying an existing result.
        /// </summary>
        /// <param name="pythonProcessResult">The source result to copy from.</param>
        public PythonProcessResult(PythonProcessResult? pythonProcessResult)
            : base(pythonProcessResult)
        {
            if (pythonProcessResult != null)
            {
                cancelled = pythonProcessResult.cancelled;
                exitCode = pythonProcessResult.exitCode;
                stalled = pythonProcessResult.stalled;
                standardError = pythonProcessResult.standardError == null ? null : [.. pythonProcessResult.standardError];
                standardOutput = pythonProcessResult.standardOutput == null ? null : [.. pythonProcessResult.standardOutput];
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PythonProcessResult"/> class using a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the result data.</param>
        public PythonProcessResult(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets a value indicating whether the process was ended because the run was cancelled.
        /// </summary>
        [JsonIgnore]
        public bool Cancelled
        {
            get
            {
                return cancelled;
            }
        }

        /// <summary>
        /// Gets the exit code of the process, or -1 when it was cancelled, ended for inactivity or failed to start.
        /// </summary>
        [JsonIgnore]
        public int ExitCode
        {
            get
            {
                return exitCode;
            }
        }

        /// <summary>
        /// Gets a value indicating whether the process was ended because it stopped producing output.
        /// </summary>
        [JsonIgnore]
        public bool Stalled
        {
            get
            {
                return stalled;
            }
        }

        /// <summary>
        /// Gets the trailing standard error lines of the process.
        /// <para>Holds the exception message as its only line when the process failed to start, and ends with the reason when the process was ended for inactivity.</para>
        /// </summary>
        [JsonIgnore]
        public List<string>? StandardError
        {
            get
            {
                return standardError;
            }
        }

        /// <summary>
        /// Gets the trailing standard output lines of the process.
        /// </summary>
        [JsonIgnore]
        public List<string>? StandardOutput
        {
            get
            {
                return standardOutput;
            }
        }
    }
}
