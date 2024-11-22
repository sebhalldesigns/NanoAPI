using System;
using NanoKit;

namespace NanoKit.System;

public static class NanoObject
{
    public static bool GetSystemType<T>(UIntPtr ptr, out UIntPtr outPtr)
    {
        if (ptr != 0)
        {
            outPtr = ptr;
            return true;
        }

        return Api.ApiLibrary.NanoApi_GetSystemType(
            Api.ApiTypeConverter.ConvertType(typeof(T)), 
            out outPtr
        ); 
    }

    public static bool DeclareCustomType<T, T2>(UIntPtr ptr, out UIntPtr outPtr)
    {
        if (ptr != 0)
        {
            outPtr = ptr;
            return true;
        }

        return Api.ApiLibrary.NanoApi_DeclareCustomType(
            Api.ApiTypeConverter.ConvertType(typeof(T)), 
            Api.ApiTypeConverter.ConvertType(typeof(T2)), 
            out outPtr
        );
    }

    public static void DeclareInstance<T>(out UIntPtr outPtr)
    {
        if (
            !Api.ApiLibrary.NanoApi_DeclareInstance(
                Api.ApiTypeConverter.ConvertType(typeof(T)),
                out outPtr
            )
        )
        {
            throw new Exception("Failed to declare instance");
        }
    }
    
}