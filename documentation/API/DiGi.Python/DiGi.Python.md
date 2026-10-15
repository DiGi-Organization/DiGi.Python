#### [DiGi\.Python](DiGi.Python.Overview.md 'DiGi\.Python\.Overview')

## DiGi\.Python Namespace
### Classes

<a name='DiGi.Python.Modify'></a>

## Modify Class

```csharp
public static class Modify
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Modify
### Methods

<a name='DiGi.Python.Modify.WriteScripts(System.Reflection.Assembly,string,string,System.Collections.Generic.IEnumerable_string_,string,System.Collections.Generic.IEnumerable_string_)'></a>

## Modify\.WriteScripts\(Assembly, string, string, IEnumerable\<string\>, string, IEnumerable\<string\>\) Method

Writes Python scripts and their companion files, shipped inside an assembly, into a directory\.

A file is taken from the folder [sourceDirectoryName](DiGi.Python.md#DiGi.Python.Modify.WriteScripts(System.Reflection.Assembly,string,string,System.Collections.Generic.IEnumerable_string_,string,System.Collections.Generic.IEnumerable_string_).sourceDirectoryName 'DiGi\.Python\.Modify\.WriteScripts\(System\.Reflection\.Assembly, string, string, System\.Collections\.Generic\.IEnumerable\<string\>, string, System\.Collections\.Generic\.IEnumerable\<string\>\)\.sourceDirectoryName') beside [assembly](DiGi.Python.md#DiGi.Python.Modify.WriteScripts(System.Reflection.Assembly,string,string,System.Collections.Generic.IEnumerable_string_,string,System.Collections.Generic.IEnumerable_string_).assembly 'DiGi\.Python\.Modify\.WriteScripts\(System\.Reflection\.Assembly, string, string, System\.Collections\.Generic\.IEnumerable\<string\>, string, System\.Collections\.Generic\.IEnumerable\<string\>\)\.assembly') when it is there, which lets a script be edited in a build output and tried without rebuilding; otherwise from the embedded resource named [resourcePrefix](DiGi.Python.md#DiGi.Python.Modify.WriteScripts(System.Reflection.Assembly,string,string,System.Collections.Generic.IEnumerable_string_,string,System.Collections.Generic.IEnumerable_string_).resourcePrefix 'DiGi\.Python\.Modify\.WriteScripts\(System\.Reflection\.Assembly, string, string, System\.Collections\.Generic\.IEnumerable\<string\>, string, System\.Collections\.Generic\.IEnumerable\<string\>\)\.resourcePrefix') followed by the file name.

Files are always rewritten, so a directory never keeps running a script of an older build. The names in [fileNames\_KeepExisting](DiGi.Python.md#DiGi.Python.Modify.WriteScripts(System.Reflection.Assembly,string,string,System.Collections.Generic.IEnumerable_string_,string,System.Collections.Generic.IEnumerable_string_).fileNames_KeepExisting 'DiGi\.Python\.Modify\.WriteScripts\(System\.Reflection\.Assembly, string, string, System\.Collections\.Generic\.IEnumerable\<string\>, string, System\.Collections\.Generic\.IEnumerable\<string\>\)\.fileNames\_KeepExisting') are the exception: they are data rather than scripts (a template configuration file, for example), so they are written only when the directory has none and never replace one written there by other means.

A script importing a sibling module is resolved by Python against the directory the script sits in, so files that import each other are only useful written together.

```csharp
public static bool WriteScripts(System.Reflection.Assembly assembly, string resourcePrefix, string sourceDirectoryName, System.Collections.Generic.IEnumerable<string> fileNames, string? directory, System.Collections.Generic.IEnumerable<string>? fileNames_KeepExisting=null);
```
#### Parameters

<a name='DiGi.Python.Modify.WriteScripts(System.Reflection.Assembly,string,string,System.Collections.Generic.IEnumerable_string_,string,System.Collections.Generic.IEnumerable_string_).assembly'></a>

`assembly` [System\.Reflection\.Assembly](https://learn.microsoft.com/en-us/dotnet/api/system.reflection.assembly 'System\.Reflection\.Assembly')

The assembly holding the embedded resources, and beside which the source folder is looked for\.

<a name='DiGi.Python.Modify.WriteScripts(System.Reflection.Assembly,string,string,System.Collections.Generic.IEnumerable_string_,string,System.Collections.Generic.IEnumerable_string_).resourcePrefix'></a>

`resourcePrefix` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The prefix of the embedded resource names, typically the default namespace and folder followed by a dot \(e\.g\. "DiGi\.YOLO\.YOLO\."\)\.

<a name='DiGi.Python.Modify.WriteScripts(System.Reflection.Assembly,string,string,System.Collections.Generic.IEnumerable_string_,string,System.Collections.Generic.IEnumerable_string_).sourceDirectoryName'></a>

`sourceDirectoryName` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the folder beside the assembly that is preferred over the embedded resources\.

<a name='DiGi.Python.Modify.WriteScripts(System.Reflection.Assembly,string,string,System.Collections.Generic.IEnumerable_string_,string,System.Collections.Generic.IEnumerable_string_).fileNames'></a>

`fileNames` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The names of the files to write\.

<a name='DiGi.Python.Modify.WriteScripts(System.Reflection.Assembly,string,string,System.Collections.Generic.IEnumerable_string_,string,System.Collections.Generic.IEnumerable_string_).directory'></a>

`directory` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The directory to write the files into, created when missing\.

<a name='DiGi.Python.Modify.WriteScripts(System.Reflection.Assembly,string,string,System.Collections.Generic.IEnumerable_string_,string,System.Collections.Generic.IEnumerable_string_).fileNames_KeepExisting'></a>

`fileNames_KeepExisting` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The names of the files written only when the directory has none \(compared case\-insensitively\), or `null`\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if every file was written or kept; otherwise, false\.

<a name='DiGi.Python.Query'></a>

## Query Class

```csharp
public static class Query
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Query
### Methods

<a name='DiGi.Python.Query.DirectorySHA256(string,System.Collections.Generic.IEnumerable_string_)'></a>

## Query\.DirectorySHA256\(string, IEnumerable\<string\>\) Method

Computes a deterministic SHA\-256 digest of the files in a directory and its subdirectories, as lowercase hexadecimal \- used to identify a model or checkpoint folder by its content\.

Each file contributes its path relative to [directory](DiGi.Python.md#DiGi.Python.Query.DirectorySHA256(string,System.Collections.Generic.IEnumerable_string_).directory 'DiGi\.Python\.Query\.DirectorySHA256\(string, System\.Collections\.Generic\.IEnumerable\<string\>\)\.directory'), written with "/" separators, a line feed, its [FileSHA256\(string\)](DiGi.Python.md#DiGi.Python.Query.FileSHA256(string) 'DiGi\.Python\.Query\.FileSHA256\(string\)') digest and a line feed. The files are ordered by that relative path (ordinal), and the digest is taken over the UTF-8 bytes of the result, so it does not depend on the order the file system enumerates them in or on the platform's directory separator.

The directory name itself is not part of the digest: the same content copied elsewhere hashes the same. A file matched by several of [searchPatterns](DiGi.Python.md#DiGi.Python.Query.DirectorySHA256(string,System.Collections.Generic.IEnumerable_string_).searchPatterns 'DiGi\.Python\.Query\.DirectorySHA256\(string, System\.Collections\.Generic\.IEnumerable\<string\>\)\.searchPatterns') is counted once. An empty directory hashes the empty input.

```csharp
public static string? DirectorySHA256(string? directory, System.Collections.Generic.IEnumerable<string>? searchPatterns=null);
```
#### Parameters

<a name='DiGi.Python.Query.DirectorySHA256(string,System.Collections.Generic.IEnumerable_string_).directory'></a>

`directory` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The directory to hash\.

<a name='DiGi.Python.Query.DirectorySHA256(string,System.Collections.Generic.IEnumerable_string_).searchPatterns'></a>

`searchPatterns` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The file name patterns of the files to include, such as "\*\.safetensors", or `null` to include every file\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The 64\-character lowercase hexadecimal digest, or `null` when the directory is empty or missing as a path, does not exist, or one of its files cannot be read\.

<a name='DiGi.Python.Query.ExecuteProcess(string,string,string,System.Collections.Generic.Dictionary_string,string_,System.Nullable_System.TimeSpan_,System.Threading.CancellationToken)'></a>

## Query\.ExecuteProcess\(string, string, string, Dictionary\<string,string\>, Nullable\<TimeSpan\>, CancellationToken\) Method

Executes a process with captured standard output and standard error streams, additional environment variables, cancellation support, and an inactivity limit that ends a process which stops producing output\.

Launches the process without creating a window, using UTF-8 encodings for both streams. Reading both streams asynchronously prevents deadlocks when process output buffers fill up. Only the last [OutputLines](DiGi.Python.Constants.md#DiGi.Python.Constants.Count.OutputLines 'DiGi\.Python\.Constants\.Count\.OutputLines') lines of each stream are kept.

Cancelling or reaching the limit ends the process together with every process it started.

The overloads keep [environmentVariables](DiGi.Python.md#DiGi.Python.Query.ExecuteProcess(string,string,string,System.Collections.Generic.Dictionary_string,string_,System.Nullable_System.TimeSpan_,System.Threading.CancellationToken).environmentVariables 'DiGi\.Python\.Query\.ExecuteProcess\(string, string, string, System\.Collections\.Generic\.Dictionary\<string,string\>, System\.Nullable\<System\.TimeSpan\>, System\.Threading\.CancellationToken\)\.environmentVariables') and [inactivityTimeout](DiGi.Python.md#DiGi.Python.Query.ExecuteProcess(string,string,string,System.Collections.Generic.Dictionary_string,string_,System.Nullable_System.TimeSpan_,System.Threading.CancellationToken).inactivityTimeout 'DiGi\.Python\.Query\.ExecuteProcess\(string, string, string, System\.Collections\.Generic\.Dictionary\<string,string\>, System\.Nullable\<System\.TimeSpan\>, System\.Threading\.CancellationToken\)\.inactivityTimeout') required here: making them optional beside the shorter overloads makes a call with three or four arguments ambiguous (CS0121).

```csharp
public static DiGi.Python.Classes.PythonProcessResult ExecuteProcess(string executablePath, string arguments, string workingDirectory, System.Collections.Generic.Dictionary<string,string>? environmentVariables, System.Nullable<System.TimeSpan> inactivityTimeout, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.Python.Query.ExecuteProcess(string,string,string,System.Collections.Generic.Dictionary_string,string_,System.Nullable_System.TimeSpan_,System.Threading.CancellationToken).executablePath'></a>

`executablePath` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The full path of the executable to run\.

<a name='DiGi.Python.Query.ExecuteProcess(string,string,string,System.Collections.Generic.Dictionary_string,string_,System.Nullable_System.TimeSpan_,System.Threading.CancellationToken).arguments'></a>

`arguments` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The command line arguments passed to the process\.

<a name='DiGi.Python.Query.ExecuteProcess(string,string,string,System.Collections.Generic.Dictionary_string,string_,System.Nullable_System.TimeSpan_,System.Threading.CancellationToken).workingDirectory'></a>

`workingDirectory` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The working directory of the process\.

<a name='DiGi.Python.Query.ExecuteProcess(string,string,string,System.Collections.Generic.Dictionary_string,string_,System.Nullable_System.TimeSpan_,System.Threading.CancellationToken).environmentVariables'></a>

`environmentVariables` [System\.Collections\.Generic\.Dictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')

The environment variables set on the process on top of the inherited environment, or `null`\.

<a name='DiGi.Python.Query.ExecuteProcess(string,string,string,System.Collections.Generic.Dictionary_string,string_,System.Nullable_System.TimeSpan_,System.Threading.CancellationToken).inactivityTimeout'></a>

`inactivityTimeout` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.TimeSpan](https://learn.microsoft.com/en-us/dotnet/api/system.timespan 'System\.TimeSpan')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The span without a line on either output stream after which the process is ended, or `null` for no limit\. A value that is not positive disables the limit as well\.

<a name='DiGi.Python.Query.ExecuteProcess(string,string,string,System.Collections.Generic.Dictionary_string,string_,System.Nullable_System.TimeSpan_,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

The token that cancels process execution\.

#### Returns
[PythonProcessResult](DiGi.Python.Classes.md#DiGi.Python.Classes.PythonProcessResult 'DiGi\.Python\.Classes\.PythonProcessResult')  
The exit code \(\-1 when the process was cancelled, ended for inactivity or failed to start\), the trailing lines of both output streams, and whether the process was ended for inactivity or cancelled\.

<a name='DiGi.Python.Query.ExecuteProcess(string,string,string,System.Collections.Generic.Dictionary_string,string_,System.Threading.CancellationToken)'></a>

## Query\.ExecuteProcess\(string, string, string, Dictionary\<string,string\>, CancellationToken\) Method

Executes a process with captured standard output and standard error streams, additional environment variables and cancellation support\.

Same contract as [ExecuteProcess\(string, string, string, Dictionary&lt;string,string&gt;, Nullable&lt;TimeSpan&gt;, CancellationToken\)](DiGi.Python.md#DiGi.Python.Query.ExecuteProcess(string,string,string,System.Collections.Generic.Dictionary_string,string_,System.Nullable_System.TimeSpan_,System.Threading.CancellationToken) 'DiGi\.Python\.Query\.ExecuteProcess\(string, string, string, System\.Collections\.Generic\.Dictionary\<string,string\>, System\.Nullable\<System\.TimeSpan\>, System\.Threading\.CancellationToken\)'), without an inactivity limit.

```csharp
public static DiGi.Python.Classes.PythonProcessResult ExecuteProcess(string executablePath, string arguments, string workingDirectory, System.Collections.Generic.Dictionary<string,string>? environmentVariables, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.Python.Query.ExecuteProcess(string,string,string,System.Collections.Generic.Dictionary_string,string_,System.Threading.CancellationToken).executablePath'></a>

`executablePath` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The full path of the executable to run\.

<a name='DiGi.Python.Query.ExecuteProcess(string,string,string,System.Collections.Generic.Dictionary_string,string_,System.Threading.CancellationToken).arguments'></a>

`arguments` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The command line arguments passed to the process\.

<a name='DiGi.Python.Query.ExecuteProcess(string,string,string,System.Collections.Generic.Dictionary_string,string_,System.Threading.CancellationToken).workingDirectory'></a>

`workingDirectory` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The working directory of the process\.

<a name='DiGi.Python.Query.ExecuteProcess(string,string,string,System.Collections.Generic.Dictionary_string,string_,System.Threading.CancellationToken).environmentVariables'></a>

`environmentVariables` [System\.Collections\.Generic\.Dictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')

The environment variables set on the process on top of the inherited environment, or `null`\.

<a name='DiGi.Python.Query.ExecuteProcess(string,string,string,System.Collections.Generic.Dictionary_string,string_,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

The token that cancels process execution\.

#### Returns
[PythonProcessResult](DiGi.Python.Classes.md#DiGi.Python.Classes.PythonProcessResult 'DiGi\.Python\.Classes\.PythonProcessResult')  
The exit code and the trailing lines of both output streams of the process\.

<a name='DiGi.Python.Query.ExecuteProcess(string,string,string,System.Threading.CancellationToken)'></a>

## Query\.ExecuteProcess\(string, string, string, CancellationToken\) Method

Executes a process with captured standard output and standard error streams while supporting cancellation\.

Same contract as [ExecuteProcess\(string, string, string, Dictionary&lt;string,string&gt;, Nullable&lt;TimeSpan&gt;, CancellationToken\)](DiGi.Python.md#DiGi.Python.Query.ExecuteProcess(string,string,string,System.Collections.Generic.Dictionary_string,string_,System.Nullable_System.TimeSpan_,System.Threading.CancellationToken) 'DiGi\.Python\.Query\.ExecuteProcess\(string, string, string, System\.Collections\.Generic\.Dictionary\<string,string\>, System\.Nullable\<System\.TimeSpan\>, System\.Threading\.CancellationToken\)'), without additional environment variables and without an inactivity limit.

```csharp
public static DiGi.Python.Classes.PythonProcessResult ExecuteProcess(string executablePath, string arguments, string workingDirectory, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.Python.Query.ExecuteProcess(string,string,string,System.Threading.CancellationToken).executablePath'></a>

`executablePath` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The full path of the executable to run\.

<a name='DiGi.Python.Query.ExecuteProcess(string,string,string,System.Threading.CancellationToken).arguments'></a>

`arguments` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The command line arguments passed to the process\.

<a name='DiGi.Python.Query.ExecuteProcess(string,string,string,System.Threading.CancellationToken).workingDirectory'></a>

`workingDirectory` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The working directory of the process\.

<a name='DiGi.Python.Query.ExecuteProcess(string,string,string,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

The token that cancels process execution\.

#### Returns
[PythonProcessResult](DiGi.Python.Classes.md#DiGi.Python.Classes.PythonProcessResult 'DiGi\.Python\.Classes\.PythonProcessResult')  
The exit code and the trailing lines of both output streams of the process\.

<a name='DiGi.Python.Query.FileSHA256(string)'></a>

## Query\.FileSHA256\(string\) Method

Computes the SHA\-256 digest of a file as lowercase hexadecimal \- the form Python's hashlib hexdigest\(\) prints, so a digest computed by a script and one computed here compare as plain strings\.

```csharp
public static string? FileSHA256(string? path);
```
#### Parameters

<a name='DiGi.Python.Query.FileSHA256(string).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The path of the file to hash\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The 64\-character lowercase hexadecimal digest, or `null` when the path is empty, the file does not exist or cannot be read\.

<a name='DiGi.Python.Query.MarkedJson(System.Collections.Generic.IEnumerable_string_,string,string)'></a>

## Query\.MarkedJson\(IEnumerable\<string\>, string, string\) Method

Finds the JSON payload a script prints between a pair of marker lines in its captured standard output\.

The payload is taken from the <b>last</b> begin marker: the non-blank lines between it and the first end marker after it, trimmed and joined with a line feed. Whatever the interpreter or the libraries print before or after the pair - a settings notice included - therefore never reaches the payload, and a script that reports twice is read by its final report.

Marker lines are compared after trimming, ordinally. The payload is returned as text; parsing it stays with the caller.

```csharp
public static string? MarkedJson(System.Collections.Generic.IEnumerable<string>? lines, string beginMarker, string endMarker);
```
#### Parameters

<a name='DiGi.Python.Query.MarkedJson(System.Collections.Generic.IEnumerable_string_,string,string).lines'></a>

`lines` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The captured standard output lines of the run\.

<a name='DiGi.Python.Query.MarkedJson(System.Collections.Generic.IEnumerable_string_,string,string).beginMarker'></a>

`beginMarker` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The marker line the script prints immediately before its JSON payload\.

<a name='DiGi.Python.Query.MarkedJson(System.Collections.Generic.IEnumerable_string_,string,string).endMarker'></a>

`endMarker` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The marker line the script prints immediately after its JSON payload\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The JSON payload text, or `null` when [lines](DiGi.Python.md#DiGi.Python.Query.MarkedJson(System.Collections.Generic.IEnumerable_string_,string,string).lines 'DiGi\.Python\.Query\.MarkedJson\(System\.Collections\.Generic\.IEnumerable\<string\>, string, string\)\.lines') is `null`, either marker is missing, no end marker follows the last begin marker, or nothing but blank lines lies between them\.

<a name='DiGi.Python.Query.NormalizedPath(string)'></a>

## Query\.NormalizedPath\(string\) Method

Returns the full form of a path with any trailing directory separator removed\.

The separator matters because these paths are handed to a process on its command line. On Windows a backslash immediately before a closing quote escapes that quote, so a directory written as "C:\scratch\" swallows the argument that follows it and the process sees something entirely different from what was intended.

A root such as "C:\" keeps its separator, because removing it would leave a drive letter that names the current directory of that drive rather than its root.

```csharp
public static string? NormalizedPath(string? path);
```
#### Parameters

<a name='DiGi.Python.Query.NormalizedPath(string).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The path to normalize\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The normalized path, or `null` when the path is null, empty, or cannot be resolved to a full path\.

<a name='DiGi.Python.Query.PythonPath(string)'></a>

## Query\.PythonPath\(string\) Method

Resolves the CPython interpreter that runs a script\.

A path that names an existing file is taken as given. Anything else, including `null`, is looked for on PATH, trying "python" and then "python3", in PATH order.

A Windows app execution alias is accepted like any other match even though it is a zero byte reparse point, because it is a working interpreter whenever its app is installed. When the app is not installed the alias opens the Microsoft Store instead and the run fails; that failure is reported through the result's standard error rather than avoided by guessing.

The interpreter is CPython, run out of process. The IronPython engine in DiGi.Scripting.Python cannot host native packages such as torch, so it is not an alternative to this.

```csharp
public static string? PythonPath(string? path);
```
#### Parameters

<a name='DiGi.Python.Query.PythonPath(string).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The path of an interpreter, the name of one on PATH, or `null` to search for one\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The full path of the interpreter, or `null` when none was found\.

<a name='DiGi.Python.Query.PythonPaths(string)'></a>

## Query\.PythonPaths\(string\) Method

Resolves all potential CPython interpreter candidate paths on PATH\.

If [path](DiGi.Python.md#DiGi.Python.Query.PythonPaths(string).path 'DiGi\.Python\.Query\.PythonPaths\(string\)\.path') names an existing file, it is returned as the single candidate. Otherwise, PATH is searched for [path](DiGi.Python.md#DiGi.Python.Query.PythonPaths(string).path 'DiGi\.Python\.Query\.PythonPaths\(string\)\.path') (if provided), "python", and "python3" in order, returning all distinct existing candidates found.

A [path](DiGi.Python.md#DiGi.Python.Query.PythonPaths(string).path 'DiGi\.Python\.Query\.PythonPaths\(string\)\.path') that is rooted or contains a directory separator but names no existing file is returned as the single candidate as well, so the caller reports the run of the interpreter it asked for rather than silently running another one.

```csharp
public static System.Collections.Generic.List<string> PythonPaths(string? path=null);
```
#### Parameters

<a name='DiGi.Python.Query.PythonPaths(string).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The full path of an interpreter, the command name of one on PATH, or `null` to search PATH\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of distinct resolved interpreter paths in search order\.