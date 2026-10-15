#### [DiGi\.Python](DiGi.Python.Overview.md 'DiGi\.Python\.Overview')

## DiGi\.Python\.Constants Namespace
### Classes

<a name='DiGi.Python.Constants.Count'></a>

## Count Class

Provides constant counts used to bound the data collected while running a Python process\.

```csharp
public static class Count
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Count
### Fields

<a name='DiGi.Python.Constants.Count.OutputLines'></a>

## Count\.OutputLines Field

The number of trailing lines kept from each of the output streams of a process run by [ExecuteProcess\(string, string, string, Dictionary&lt;string,string&gt;, Nullable&lt;TimeSpan&gt;, CancellationToken\)](DiGi.Python.md#DiGi.Python.Query.ExecuteProcess(string,string,string,System.Collections.Generic.Dictionary_string,string_,System.Nullable_System.TimeSpan_,System.Threading.CancellationToken) 'DiGi\.Python\.Query\.ExecuteProcess\(string, string, string, System\.Collections\.Generic\.Dictionary\<string,string\>, System\.Nullable\<System\.TimeSpan\>, System\.Threading\.CancellationToken\)')\.

A long running script, together with the libraries it uses, can write megabytes to its output streams. Only the tail is kept, because that is the part carrying the reason a run ended the way it did.

```csharp
public const int OutputLines = 200;
```

#### Field Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')