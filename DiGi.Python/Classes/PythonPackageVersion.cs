using DiGi.Core.Classes;
using DiGi.Python.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Python.Classes
{
    /// <summary>
    /// Represents the installed version of one Python package, as reported by the interpreter.
    /// <para>Held in a list by <see cref="PythonEnvironmentResult.Packages"/> rather than in a dictionary keyed by name, because the DiGi serializer rebuilds a dictionary with the default comparer of its type and files every key as a JSON object name.</para>
    /// </summary>
    public class PythonPackageVersion : SerializableObject, IPythonSerializableObject
    {
        [JsonInclude, JsonPropertyName(nameof(Name))]
        private readonly string? name;

        [JsonInclude, JsonPropertyName(nameof(Version))]
        private readonly string? version;

        /// <summary>
        /// Initializes a new instance of the <see cref="PythonPackageVersion"/> class.
        /// </summary>
        /// <param name="name">The name of the package as imported or installed, such as "torch".</param>
        /// <param name="version">The installed version of the package, or <c>null</c> when it could not be imported.</param>
        public PythonPackageVersion(string? name, string? version)
        {
            this.name = name;
            this.version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PythonPackageVersion"/> class by copying an existing package version.
        /// </summary>
        /// <param name="pythonPackageVersion">The source package version to copy from.</param>
        public PythonPackageVersion(PythonPackageVersion? pythonPackageVersion)
            : base(pythonPackageVersion)
        {
            if (pythonPackageVersion != null)
            {
                name = pythonPackageVersion.name;
                version = pythonPackageVersion.version;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PythonPackageVersion"/> class using a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the package version data.</param>
        public PythonPackageVersion(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets the name of the package as imported or installed, such as "torch".
        /// </summary>
        [JsonIgnore]
        public string? Name
        {
            get
            {
                return name;
            }
        }

        /// <summary>
        /// Gets the installed version of the package, or <c>null</c> when it could not be imported.
        /// </summary>
        [JsonIgnore]
        public string? Version
        {
            get
            {
                return version;
            }
        }
    }
}
