using System;
using NanoKit;

namespace NanoKit.System;

public class NanoParameter<T>
{
    private UIntPtr _ptr = 0;
    private T _value;

    public NanoParameter(Type targetType, string name, T value)
    {
        _value = value;
        if (
            !Api.ApiLibrary.NanoApi_AddParameter(
                Api.ApiTypeConverter.ConvertType(targetType), 
                name, 
                Api.ApiTypeConverter.ConvertType(typeof(T)),
                out _ptr
            )
        )
        {
            throw new Exception("Failed to add parameter to target type");
        }
    }   
}