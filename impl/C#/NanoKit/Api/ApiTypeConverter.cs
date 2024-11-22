using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace NanoKit.Api;

public static class ApiTypeConverter
{
    public static string ConvertType(Type type)
    {
        if (type == typeof(int))
        {
            return "Int32";
        }
        else if (type == typeof(float))
        {
            return "Float32";
        }
        else if (type == typeof(double))
        {
            return "Float64";
        }
        else if (type == typeof(string))
        {
            return "String";
        }
        else if (type == typeof(bool))
        {
            return "Bool";
        }
        else if (type == typeof(char))
        {
            return "UInt16";
        }
        else if (type == typeof(byte))
        {
            return "UInt8";
        }
        else if (type == typeof(short))
        {
            return "Int16";
        }
        else if (type == typeof(long))
        {
            return "Int64";
        }
        else if (type == typeof(uint))
        {
            return "UInt32";
        }
        else if (type == typeof(ushort))
        {
            return "UInt16";
        }
        else if (type == typeof(ulong))
        {
            return "UInt64";
        }
        else if (type == typeof(sbyte))
        {
            return "Int8";
        }
        else
        {
            return type.FullName;
        }
    }
}