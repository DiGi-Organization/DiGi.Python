#### [DiGi\.Python](DiGi.Python.Overview.md 'DiGi\.Python\.Overview')

## DiGi\.Python\.Classes Namespace
### Classes

<a name='DiGi.Python.Classes.PythonEnvironmentResult'></a>

## PythonEnvironmentResult Class

Represents the preflight check result of probing a CPython environment on a machine\.

Reports whether the interpreter can run the caller's workload, its version, the installed package versions, CUDA availability, and diagnostic messages explaining why the environment is not runnable. Non-fatal findings are reported in [Warnings](DiGi.Python.Classes.md#DiGi.Python.Classes.PythonEnvironmentResult.Warnings 'DiGi\.Python\.Classes\.PythonEnvironmentResult\.Warnings') and do not affect [Runnable](DiGi.Python.Classes.md#DiGi.Python.Classes.PythonEnvironmentResult.Runnable 'DiGi\.Python\.Classes\.PythonEnvironmentResult\.Runnable').

Not sealed: a library adds its own findings by deriving from it. The DiGi serializer keys members by name across the hierarchy and lets the derived one win, so a derived type must not reuse any member name declared here.

```csharp
public class PythonEnvironmentResult : DiGi.Core.Classes.SerializableResult, DiGi.Python.Interfaces.IPythonSerializableObject, DiGi.Python.Interfaces.IPythonObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.SerializableResult](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableresult 'DiGi\.Core\.Classes\.SerializableResult') → PythonEnvironmentResult

Implements [IPythonSerializableObject](DiGi.Python.Interfaces.md#DiGi.Python.Interfaces.IPythonSerializableObject 'DiGi\.Python\.Interfaces\.IPythonSerializableObject'), [IPythonObject](DiGi.Python.Interfaces.md#DiGi.Python.Interfaces.IPythonObject 'DiGi\.Python\.Interfaces\.IPythonObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')
### Constructors

<a name='DiGi.Python.Classes.PythonEnvironmentResult.PythonEnvironmentResult(bool,string,string,System.Nullable_bool_,System.Collections.Generic.IEnumerable_DiGi.Python.Classes.PythonPackageVersion_,System.Collections.Generic.IEnumerable_string_,System.Collections.Generic.IEnumerable_string_,System.Nullable_System.DateTimeOffset_)'></a>

## PythonEnvironmentResult\(bool, string, string, Nullable\<bool\>, IEnumerable\<PythonPackageVersion\>, IEnumerable\<string\>, IEnumerable\<string\>, Nullable\<DateTimeOffset\>\) Constructor

Initializes a new instance of the [PythonEnvironmentResult](DiGi.Python.Classes.md#DiGi.Python.Classes.PythonEnvironmentResult 'DiGi\.Python\.Classes\.PythonEnvironmentResult') class\.

```csharp
public PythonEnvironmentResult(bool runnable, string? pythonPath, string? pythonVersion, System.Nullable<bool> cudaAvailable, System.Collections.Generic.IEnumerable<DiGi.Python.Classes.PythonPackageVersion>? packages, System.Collections.Generic.IEnumerable<string>? messages, System.Collections.Generic.IEnumerable<string>? warnings, System.Nullable<System.DateTimeOffset> checkedTime);
```
#### Parameters

<a name='DiGi.Python.Classes.PythonEnvironmentResult.PythonEnvironmentResult(bool,string,string,System.Nullable_bool_,System.Collections.Generic.IEnumerable_DiGi.Python.Classes.PythonPackageVersion_,System.Collections.Generic.IEnumerable_string_,System.Collections.Generic.IEnumerable_string_,System.Nullable_System.DateTimeOffset_).runnable'></a>

`runnable` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether the probed interpreter can run the caller's workload\.

<a name='DiGi.Python.Classes.PythonEnvironmentResult.PythonEnvironmentResult(bool,string,string,System.Nullable_bool_,System.Collections.Generic.IEnumerable_DiGi.Python.Classes.PythonPackageVersion_,System.Collections.Generic.IEnumerable_string_,System.Collections.Generic.IEnumerable_string_,System.Nullable_System.DateTimeOffset_).pythonPath'></a>

`pythonPath` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The full path of the interpreter that was probed\.

<a name='DiGi.Python.Classes.PythonEnvironmentResult.PythonEnvironmentResult(bool,string,string,System.Nullable_bool_,System.Collections.Generic.IEnumerable_DiGi.Python.Classes.PythonPackageVersion_,System.Collections.Generic.IEnumerable_string_,System.Collections.Generic.IEnumerable_string_,System.Nullable_System.DateTimeOffset_).pythonVersion'></a>

`pythonVersion` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The Python version reported by the interpreter\.

<a name='DiGi.Python.Classes.PythonEnvironmentResult.PythonEnvironmentResult(bool,string,string,System.Nullable_bool_,System.Collections.Generic.IEnumerable_DiGi.Python.Classes.PythonPackageVersion_,System.Collections.Generic.IEnumerable_string_,System.Collections.Generic.IEnumerable_string_,System.Nullable_System.DateTimeOffset_).cudaAvailable'></a>

`cudaAvailable` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

A value indicating whether the interpreter reports CUDA acceleration available, or `null` when it was not determined\.

<a name='DiGi.Python.Classes.PythonEnvironmentResult.PythonEnvironmentResult(bool,string,string,System.Nullable_bool_,System.Collections.Generic.IEnumerable_DiGi.Python.Classes.PythonPackageVersion_,System.Collections.Generic.IEnumerable_string_,System.Collections.Generic.IEnumerable_string_,System.Nullable_System.DateTimeOffset_).packages'></a>

`packages` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[PythonPackageVersion](DiGi.Python.Classes.md#DiGi.Python.Classes.PythonPackageVersion 'DiGi\.Python\.Classes\.PythonPackageVersion')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The installed versions of the packages that were probed\.

<a name='DiGi.Python.Classes.PythonEnvironmentResult.PythonEnvironmentResult(bool,string,string,System.Nullable_bool_,System.Collections.Generic.IEnumerable_DiGi.Python.Classes.PythonPackageVersion_,System.Collections.Generic.IEnumerable_string_,System.Collections.Generic.IEnumerable_string_,System.Nullable_System.DateTimeOffset_).messages'></a>

`messages` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The diagnostic messages detailing why the environment is not runnable\.

<a name='DiGi.Python.Classes.PythonEnvironmentResult.PythonEnvironmentResult(bool,string,string,System.Nullable_bool_,System.Collections.Generic.IEnumerable_DiGi.Python.Classes.PythonPackageVersion_,System.Collections.Generic.IEnumerable_string_,System.Collections.Generic.IEnumerable_string_,System.Nullable_System.DateTimeOffset_).warnings'></a>

`warnings` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The diagnostic messages that do not prevent the environment from running\.

<a name='DiGi.Python.Classes.PythonEnvironmentResult.PythonEnvironmentResult(bool,string,string,System.Nullable_bool_,System.Collections.Generic.IEnumerable_DiGi.Python.Classes.PythonPackageVersion_,System.Collections.Generic.IEnumerable_string_,System.Collections.Generic.IEnumerable_string_,System.Nullable_System.DateTimeOffset_).checkedTime'></a>

`checkedTime` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.DateTimeOffset](https://learn.microsoft.com/en-us/dotnet/api/system.datetimeoffset 'System\.DateTimeOffset')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The moment the preflight probe completed\.

<a name='DiGi.Python.Classes.PythonEnvironmentResult.PythonEnvironmentResult(DiGi.Python.Classes.PythonEnvironmentResult)'></a>

## PythonEnvironmentResult\(PythonEnvironmentResult\) Constructor

Initializes a new instance of the [PythonEnvironmentResult](DiGi.Python.Classes.md#DiGi.Python.Classes.PythonEnvironmentResult 'DiGi\.Python\.Classes\.PythonEnvironmentResult') class by copying an existing result\.

```csharp
public PythonEnvironmentResult(DiGi.Python.Classes.PythonEnvironmentResult? pythonEnvironmentResult);
```
#### Parameters

<a name='DiGi.Python.Classes.PythonEnvironmentResult.PythonEnvironmentResult(DiGi.Python.Classes.PythonEnvironmentResult).pythonEnvironmentResult'></a>

`pythonEnvironmentResult` [PythonEnvironmentResult](DiGi.Python.Classes.md#DiGi.Python.Classes.PythonEnvironmentResult 'DiGi\.Python\.Classes\.PythonEnvironmentResult')

The source result to copy from\.

<a name='DiGi.Python.Classes.PythonEnvironmentResult.PythonEnvironmentResult(System.Text.Json.Nodes.JsonObject)'></a>

## PythonEnvironmentResult\(JsonObject\) Constructor

Initializes a new instance of the [PythonEnvironmentResult](DiGi.Python.Classes.md#DiGi.Python.Classes.PythonEnvironmentResult 'DiGi\.Python\.Classes\.PythonEnvironmentResult') class using a JSON object\.

```csharp
public PythonEnvironmentResult(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Python.Classes.PythonEnvironmentResult.PythonEnvironmentResult(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the result data\.
### Properties

<a name='DiGi.Python.Classes.PythonEnvironmentResult.Checked'></a>

## PythonEnvironmentResult\.Checked Property

Gets the moment the preflight probe completed\.

```csharp
public System.Nullable<System.DateTimeOffset> Checked { get; }
```

#### Property Value
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.DateTimeOffset](https://learn.microsoft.com/en-us/dotnet/api/system.datetimeoffset 'System\.DateTimeOffset')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

<a name='DiGi.Python.Classes.PythonEnvironmentResult.CudaAvailable'></a>

## PythonEnvironmentResult\.CudaAvailable Property

Gets a value indicating whether the interpreter reports CUDA acceleration available, or `null` when it was not determined\.

```csharp
public System.Nullable<bool> CudaAvailable { get; }
```

#### Property Value
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

<a name='DiGi.Python.Classes.PythonEnvironmentResult.Messages'></a>

## PythonEnvironmentResult\.Messages Property

Gets the diagnostic messages detailing why the environment is not runnable\.

Non-fatal findings are reported in [Warnings](DiGi.Python.Classes.md#DiGi.Python.Classes.PythonEnvironmentResult.Warnings 'DiGi\.Python\.Classes\.PythonEnvironmentResult\.Warnings') instead.

```csharp
public System.Collections.Generic.List<string>? Messages { get; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.Python.Classes.PythonEnvironmentResult.Packages'></a>

## PythonEnvironmentResult\.Packages Property

Gets the installed versions of the packages that were probed\.

```csharp
public System.Collections.Generic.List<DiGi.Python.Classes.PythonPackageVersion>? Packages { get; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[PythonPackageVersion](DiGi.Python.Classes.md#DiGi.Python.Classes.PythonPackageVersion 'DiGi\.Python\.Classes\.PythonPackageVersion')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.Python.Classes.PythonEnvironmentResult.PythonPath'></a>

## PythonEnvironmentResult\.PythonPath Property

Gets the full path of the interpreter that was probed\.

```csharp
public string? PythonPath { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Python.Classes.PythonEnvironmentResult.PythonVersion'></a>

## PythonEnvironmentResult\.PythonVersion Property

Gets the Python version reported by the interpreter\.

```csharp
public string? PythonVersion { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Python.Classes.PythonEnvironmentResult.Runnable'></a>

## PythonEnvironmentResult\.Runnable Property

Gets a value indicating whether the probed interpreter can run the caller's workload\.

```csharp
public bool Runnable { get; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='DiGi.Python.Classes.PythonEnvironmentResult.Warnings'></a>

## PythonEnvironmentResult\.Warnings Property

Gets the diagnostic messages that do not prevent the environment from running\.

```csharp
public System.Collections.Generic.List<string>? Warnings { get; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.Python.Classes.PythonPackageVersion'></a>

## PythonPackageVersion Class

Represents the installed version of one Python package, as reported by the interpreter\.

Held in a list by [Packages](DiGi.Python.Classes.md#DiGi.Python.Classes.PythonEnvironmentResult.Packages 'DiGi\.Python\.Classes\.PythonEnvironmentResult\.Packages') rather than in a dictionary keyed by name, because the DiGi serializer rebuilds a dictionary with the default comparer of its type and files every key as a JSON object name.

```csharp
public class PythonPackageVersion : DiGi.Core.Classes.SerializableObject, DiGi.Python.Interfaces.IPythonSerializableObject, DiGi.Python.Interfaces.IPythonObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → PythonPackageVersion

Implements [IPythonSerializableObject](DiGi.Python.Interfaces.md#DiGi.Python.Interfaces.IPythonSerializableObject 'DiGi\.Python\.Interfaces\.IPythonSerializableObject'), [IPythonObject](DiGi.Python.Interfaces.md#DiGi.Python.Interfaces.IPythonObject 'DiGi\.Python\.Interfaces\.IPythonObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')
### Constructors

<a name='DiGi.Python.Classes.PythonPackageVersion.PythonPackageVersion(DiGi.Python.Classes.PythonPackageVersion)'></a>

## PythonPackageVersion\(PythonPackageVersion\) Constructor

Initializes a new instance of the [PythonPackageVersion](DiGi.Python.Classes.md#DiGi.Python.Classes.PythonPackageVersion 'DiGi\.Python\.Classes\.PythonPackageVersion') class by copying an existing package version\.

```csharp
public PythonPackageVersion(DiGi.Python.Classes.PythonPackageVersion? pythonPackageVersion);
```
#### Parameters

<a name='DiGi.Python.Classes.PythonPackageVersion.PythonPackageVersion(DiGi.Python.Classes.PythonPackageVersion).pythonPackageVersion'></a>

`pythonPackageVersion` [PythonPackageVersion](DiGi.Python.Classes.md#DiGi.Python.Classes.PythonPackageVersion 'DiGi\.Python\.Classes\.PythonPackageVersion')

The source package version to copy from\.

<a name='DiGi.Python.Classes.PythonPackageVersion.PythonPackageVersion(string,string)'></a>

## PythonPackageVersion\(string, string\) Constructor

Initializes a new instance of the [PythonPackageVersion](DiGi.Python.Classes.md#DiGi.Python.Classes.PythonPackageVersion 'DiGi\.Python\.Classes\.PythonPackageVersion') class\.

```csharp
public PythonPackageVersion(string? name, string? version);
```
#### Parameters

<a name='DiGi.Python.Classes.PythonPackageVersion.PythonPackageVersion(string,string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the package as imported or installed, such as "torch"\.

<a name='DiGi.Python.Classes.PythonPackageVersion.PythonPackageVersion(string,string).version'></a>

`version` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The installed version of the package, or `null` when it could not be imported\.

<a name='DiGi.Python.Classes.PythonPackageVersion.PythonPackageVersion(System.Text.Json.Nodes.JsonObject)'></a>

## PythonPackageVersion\(JsonObject\) Constructor

Initializes a new instance of the [PythonPackageVersion](DiGi.Python.Classes.md#DiGi.Python.Classes.PythonPackageVersion 'DiGi\.Python\.Classes\.PythonPackageVersion') class using a JSON object\.

```csharp
public PythonPackageVersion(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Python.Classes.PythonPackageVersion.PythonPackageVersion(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the package version data\.
### Properties

<a name='DiGi.Python.Classes.PythonPackageVersion.Name'></a>

## PythonPackageVersion\.Name Property

Gets the name of the package as imported or installed, such as "torch"\.

```csharp
public string? Name { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Python.Classes.PythonPackageVersion.Version'></a>

## PythonPackageVersion\.Version Property

Gets the installed version of the package, or `null` when it could not be imported\.

```csharp
public string? Version { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Python.Classes.PythonProcessResult'></a>

## PythonProcessResult Class

Represents the outcome of a process run by [ExecuteProcess\(string, string, string, Dictionary&lt;string,string&gt;, Nullable&lt;TimeSpan&gt;, CancellationToken\)](DiGi.Python.md#DiGi.Python.Query.ExecuteProcess(string,string,string,System.Collections.Generic.Dictionary_string,string_,System.Nullable_System.TimeSpan_,System.Threading.CancellationToken) 'DiGi\.Python\.Query\.ExecuteProcess\(string, string, string, System\.Collections\.Generic\.Dictionary\<string,string\>, System\.Nullable\<System\.TimeSpan\>, System\.Threading\.CancellationToken\)')\.

Only the last [OutputLines](DiGi.Python.Constants.md#DiGi.Python.Constants.Count.OutputLines 'DiGi\.Python\.Constants\.Count\.OutputLines') lines of each output stream are kept, because that is the part carrying the reason a run ended the way it did.

```csharp
public class PythonProcessResult : DiGi.Core.Classes.SerializableResult, DiGi.Python.Interfaces.IPythonSerializableObject, DiGi.Python.Interfaces.IPythonObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.SerializableResult](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableresult 'DiGi\.Core\.Classes\.SerializableResult') → PythonProcessResult

Implements [IPythonSerializableObject](DiGi.Python.Interfaces.md#DiGi.Python.Interfaces.IPythonSerializableObject 'DiGi\.Python\.Interfaces\.IPythonSerializableObject'), [IPythonObject](DiGi.Python.Interfaces.md#DiGi.Python.Interfaces.IPythonObject 'DiGi\.Python\.Interfaces\.IPythonObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')
### Constructors

<a name='DiGi.Python.Classes.PythonProcessResult.PythonProcessResult(DiGi.Python.Classes.PythonProcessResult)'></a>

## PythonProcessResult\(PythonProcessResult\) Constructor

Initializes a new instance of the [PythonProcessResult](DiGi.Python.Classes.md#DiGi.Python.Classes.PythonProcessResult 'DiGi\.Python\.Classes\.PythonProcessResult') class by copying an existing result\.

```csharp
public PythonProcessResult(DiGi.Python.Classes.PythonProcessResult? pythonProcessResult);
```
#### Parameters

<a name='DiGi.Python.Classes.PythonProcessResult.PythonProcessResult(DiGi.Python.Classes.PythonProcessResult).pythonProcessResult'></a>

`pythonProcessResult` [PythonProcessResult](DiGi.Python.Classes.md#DiGi.Python.Classes.PythonProcessResult 'DiGi\.Python\.Classes\.PythonProcessResult')

The source result to copy from\.

<a name='DiGi.Python.Classes.PythonProcessResult.PythonProcessResult(int,System.Collections.Generic.IEnumerable_string_,System.Collections.Generic.IEnumerable_string_,bool,bool)'></a>

## PythonProcessResult\(int, IEnumerable\<string\>, IEnumerable\<string\>, bool, bool\) Constructor

Initializes a new instance of the [PythonProcessResult](DiGi.Python.Classes.md#DiGi.Python.Classes.PythonProcessResult 'DiGi\.Python\.Classes\.PythonProcessResult') class\.

```csharp
public PythonProcessResult(int exitCode, System.Collections.Generic.IEnumerable<string>? standardOutput, System.Collections.Generic.IEnumerable<string>? standardError, bool stalled, bool cancelled);
```
#### Parameters

<a name='DiGi.Python.Classes.PythonProcessResult.PythonProcessResult(int,System.Collections.Generic.IEnumerable_string_,System.Collections.Generic.IEnumerable_string_,bool,bool).exitCode'></a>

`exitCode` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The exit code of the process, or \-1 when it was cancelled, ended for inactivity or failed to start\.

<a name='DiGi.Python.Classes.PythonProcessResult.PythonProcessResult(int,System.Collections.Generic.IEnumerable_string_,System.Collections.Generic.IEnumerable_string_,bool,bool).standardOutput'></a>

`standardOutput` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The trailing standard output lines of the process\.

<a name='DiGi.Python.Classes.PythonProcessResult.PythonProcessResult(int,System.Collections.Generic.IEnumerable_string_,System.Collections.Generic.IEnumerable_string_,bool,bool).standardError'></a>

`standardError` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The trailing standard error lines of the process\.

<a name='DiGi.Python.Classes.PythonProcessResult.PythonProcessResult(int,System.Collections.Generic.IEnumerable_string_,System.Collections.Generic.IEnumerable_string_,bool,bool).stalled'></a>

`stalled` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether the process was ended because it stopped producing output\.

<a name='DiGi.Python.Classes.PythonProcessResult.PythonProcessResult(int,System.Collections.Generic.IEnumerable_string_,System.Collections.Generic.IEnumerable_string_,bool,bool).cancelled'></a>

`cancelled` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether the process was ended because the run was cancelled\.

<a name='DiGi.Python.Classes.PythonProcessResult.PythonProcessResult(System.Text.Json.Nodes.JsonObject)'></a>

## PythonProcessResult\(JsonObject\) Constructor

Initializes a new instance of the [PythonProcessResult](DiGi.Python.Classes.md#DiGi.Python.Classes.PythonProcessResult 'DiGi\.Python\.Classes\.PythonProcessResult') class using a JSON object\.

```csharp
public PythonProcessResult(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Python.Classes.PythonProcessResult.PythonProcessResult(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the result data\.
### Properties

<a name='DiGi.Python.Classes.PythonProcessResult.Cancelled'></a>

## PythonProcessResult\.Cancelled Property

Gets a value indicating whether the process was ended because the run was cancelled\.

```csharp
public bool Cancelled { get; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='DiGi.Python.Classes.PythonProcessResult.ExitCode'></a>

## PythonProcessResult\.ExitCode Property

Gets the exit code of the process, or \-1 when it was cancelled, ended for inactivity or failed to start\.

```csharp
public int ExitCode { get; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.Python.Classes.PythonProcessResult.Stalled'></a>

## PythonProcessResult\.Stalled Property

Gets a value indicating whether the process was ended because it stopped producing output\.

```csharp
public bool Stalled { get; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='DiGi.Python.Classes.PythonProcessResult.StandardError'></a>

## PythonProcessResult\.StandardError Property

Gets the trailing standard error lines of the process\.

Holds the exception message as its only line when the process failed to start, and ends with the reason when the process was ended for inactivity.

```csharp
public System.Collections.Generic.List<string>? StandardError { get; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.Python.Classes.PythonProcessResult.StandardOutput'></a>

## PythonProcessResult\.StandardOutput Property

Gets the trailing standard output lines of the process\.

```csharp
public System.Collections.Generic.List<string>? StandardOutput { get; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')