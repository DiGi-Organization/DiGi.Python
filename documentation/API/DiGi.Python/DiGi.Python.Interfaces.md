#### [DiGi\.Python](DiGi.Python.Overview.md 'DiGi\.Python\.Overview')

## DiGi\.Python\.Interfaces Namespace
### Interfaces

<a name='DiGi.Python.Interfaces.IPythonObject'></a>

## IPythonObject Interface

Marker interface implemented by every object belonging to the DiGi\.Python domain\.

```csharp
public interface IPythonObject : DiGi.Core.Interfaces.IObject
```

Derived  
↳ [PythonEnvironmentResult](DiGi.Python.Classes.md#DiGi.Python.Classes.PythonEnvironmentResult 'DiGi\.Python\.Classes\.PythonEnvironmentResult')  
↳ [PythonPackageVersion](DiGi.Python.Classes.md#DiGi.Python.Classes.PythonPackageVersion 'DiGi\.Python\.Classes\.PythonPackageVersion')  
↳ [PythonProcessResult](DiGi.Python.Classes.md#DiGi.Python.Classes.PythonProcessResult 'DiGi\.Python\.Classes\.PythonProcessResult')  
↳ [IPythonSerializableObject](DiGi.Python.Interfaces.md#DiGi.Python.Interfaces.IPythonSerializableObject 'DiGi\.Python\.Interfaces\.IPythonSerializableObject')

Implements [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')

<a name='DiGi.Python.Interfaces.IPythonSerializableObject'></a>

## IPythonSerializableObject Interface

Marker interface implemented by every DiGi\.Python object that can be serialized to and from JSON\.

```csharp
public interface IPythonSerializableObject : DiGi.Python.Interfaces.IPythonObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Derived  
↳ [PythonEnvironmentResult](DiGi.Python.Classes.md#DiGi.Python.Classes.PythonEnvironmentResult 'DiGi\.Python\.Classes\.PythonEnvironmentResult')  
↳ [PythonPackageVersion](DiGi.Python.Classes.md#DiGi.Python.Classes.PythonPackageVersion 'DiGi\.Python\.Classes\.PythonPackageVersion')  
↳ [PythonProcessResult](DiGi.Python.Classes.md#DiGi.Python.Classes.PythonProcessResult 'DiGi\.Python\.Classes\.PythonProcessResult')

Implements [IPythonObject](DiGi.Python.Interfaces.md#DiGi.Python.Interfaces.IPythonObject 'DiGi\.Python\.Interfaces\.IPythonObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')