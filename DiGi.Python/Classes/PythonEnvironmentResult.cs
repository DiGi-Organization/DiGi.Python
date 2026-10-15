using DiGi.Core.Classes;
using DiGi.Python.Interfaces;
using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Python.Classes
{
    /// <summary>
    /// Represents the preflight check result of probing a CPython environment on a machine.
    /// <para>Reports whether the interpreter can run the caller's workload, its version, the installed package versions, CUDA availability, and diagnostic messages explaining why the environment is not runnable. Non-fatal findings are reported in <see cref="Warnings"/> and do not affect <see cref="Runnable"/>.</para>
    /// <para>Not sealed: a library adds its own findings by deriving from it. The DiGi serializer keys members by name across the hierarchy and lets the derived one win, so a derived type must not reuse any member name declared here.</para>
    /// </summary>
    public class PythonEnvironmentResult : SerializableResult, IPythonSerializableObject
    {
        [JsonInclude, JsonPropertyName(nameof(Checked))]
        private readonly DateTimeOffset? checkedTime;

        [JsonInclude, JsonPropertyName(nameof(CudaAvailable))]
        private readonly bool? cudaAvailable;

        [JsonInclude, JsonPropertyName(nameof(Messages))]
        private readonly List<string>? messages;

        [JsonInclude, JsonPropertyName(nameof(Packages))]
        private readonly List<PythonPackageVersion>? packages;

        [JsonInclude, JsonPropertyName(nameof(PythonPath))]
        private readonly string? pythonPath;

        [JsonInclude, JsonPropertyName(nameof(PythonVersion))]
        private readonly string? pythonVersion;

        [JsonInclude, JsonPropertyName(nameof(Runnable))]
        private readonly bool runnable;

        [JsonInclude, JsonPropertyName(nameof(Warnings))]
        private readonly List<string>? warnings;

        /// <summary>
        /// Initializes a new instance of the <see cref="PythonEnvironmentResult"/> class.
        /// </summary>
        /// <param name="runnable">A value indicating whether the probed interpreter can run the caller's workload.</param>
        /// <param name="pythonPath">The full path of the interpreter that was probed.</param>
        /// <param name="pythonVersion">The Python version reported by the interpreter.</param>
        /// <param name="cudaAvailable">A value indicating whether the interpreter reports CUDA acceleration available, or <c>null</c> when it was not determined.</param>
        /// <param name="packages">The installed versions of the packages that were probed.</param>
        /// <param name="messages">The diagnostic messages detailing why the environment is not runnable.</param>
        /// <param name="warnings">The diagnostic messages that do not prevent the environment from running.</param>
        /// <param name="checkedTime">The moment the preflight probe completed.</param>
        public PythonEnvironmentResult(
            bool runnable,
            string? pythonPath,
            string? pythonVersion,
            bool? cudaAvailable,
            IEnumerable<PythonPackageVersion>? packages,
            IEnumerable<string>? messages,
            IEnumerable<string>? warnings,
            DateTimeOffset? checkedTime)
        {
            this.runnable = runnable;
            this.pythonPath = pythonPath;
            this.pythonVersion = pythonVersion;
            this.cudaAvailable = cudaAvailable;
            this.packages = packages == null ? null : [.. packages];
            this.messages = messages == null ? null : [.. messages];
            this.warnings = warnings == null ? null : [.. warnings];
            this.checkedTime = checkedTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PythonEnvironmentResult"/> class by copying an existing result.
        /// </summary>
        /// <param name="pythonEnvironmentResult">The source result to copy from.</param>
        public PythonEnvironmentResult(PythonEnvironmentResult? pythonEnvironmentResult)
            : base(pythonEnvironmentResult)
        {
            if (pythonEnvironmentResult != null)
            {
                checkedTime = pythonEnvironmentResult.checkedTime;
                cudaAvailable = pythonEnvironmentResult.cudaAvailable;
                messages = pythonEnvironmentResult.messages == null ? null : [.. pythonEnvironmentResult.messages];
                pythonPath = pythonEnvironmentResult.pythonPath;
                pythonVersion = pythonEnvironmentResult.pythonVersion;
                runnable = pythonEnvironmentResult.runnable;
                warnings = pythonEnvironmentResult.warnings == null ? null : [.. pythonEnvironmentResult.warnings];

                if (pythonEnvironmentResult.packages != null)
                {
                    packages = [];
                    foreach (PythonPackageVersion pythonPackageVersion in pythonEnvironmentResult.packages)
                    {
                        if (Core.Query.Clone(pythonPackageVersion) is PythonPackageVersion pythonPackageVersion_Clone)
                        {
                            packages.Add(pythonPackageVersion_Clone);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PythonEnvironmentResult"/> class using a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the result data.</param>
        public PythonEnvironmentResult(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets the moment the preflight probe completed.
        /// </summary>
        [JsonIgnore]
        public DateTimeOffset? Checked
        {
            get
            {
                return checkedTime;
            }
        }

        /// <summary>
        /// Gets a value indicating whether the interpreter reports CUDA acceleration available, or <c>null</c> when it was not determined.
        /// </summary>
        [JsonIgnore]
        public bool? CudaAvailable
        {
            get
            {
                return cudaAvailable;
            }
        }

        /// <summary>
        /// Gets the diagnostic messages detailing why the environment is not runnable.
        /// <para>Non-fatal findings are reported in <see cref="Warnings"/> instead.</para>
        /// </summary>
        [JsonIgnore]
        public List<string>? Messages
        {
            get
            {
                return messages;
            }
        }

        /// <summary>
        /// Gets the installed versions of the packages that were probed.
        /// </summary>
        [JsonIgnore]
        public List<PythonPackageVersion>? Packages
        {
            get
            {
                return packages;
            }
        }

        /// <summary>
        /// Gets the full path of the interpreter that was probed.
        /// </summary>
        [JsonIgnore]
        public string? PythonPath
        {
            get
            {
                return pythonPath;
            }
        }

        /// <summary>
        /// Gets the Python version reported by the interpreter.
        /// </summary>
        [JsonIgnore]
        public string? PythonVersion
        {
            get
            {
                return pythonVersion;
            }
        }

        /// <summary>
        /// Gets a value indicating whether the probed interpreter can run the caller's workload.
        /// </summary>
        [JsonIgnore]
        public bool Runnable
        {
            get
            {
                return runnable;
            }
        }

        /// <summary>
        /// Gets the diagnostic messages that do not prevent the environment from running.
        /// </summary>
        [JsonIgnore]
        public List<string>? Warnings
        {
            get
            {
                return warnings;
            }
        }
    }
}
