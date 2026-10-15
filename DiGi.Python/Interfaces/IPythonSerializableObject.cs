namespace DiGi.Python.Interfaces
{
    /// <summary>
    /// Marker interface implemented by every DiGi.Python object that can be serialized to and from JSON.
    /// </summary>
    public interface IPythonSerializableObject : IPythonObject, Core.Interfaces.ISerializableObject
    {
    }
}
