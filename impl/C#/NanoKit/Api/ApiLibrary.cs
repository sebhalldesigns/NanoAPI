using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace NanoKit.Api;

public static class ApiLibrary
{
    [DllImport("libNanoApi.dll", SetLastError = true)]
    public static extern void NanoApi_Init();

    [DllImport("libNanoApi.dll", SetLastError = true)]
    public static extern bool NanoApi_GetSystemType(string typeName, out UIntPtr outPtr);

    [DllImport("libNanoApi.dll", SetLastError = true)]
    public static extern bool NanoApi_DeclareCustomType(string typeName, string baseTypeName, out UIntPtr outPtr);

    [DllImport("libNanoApi.dll", SetLastError = true)]
    public static extern bool NanoApi_AddParameter(string targetName, string name, string typeName, out UIntPtr outPtr);

    [DllImport("libNanoApi.dll", SetLastError = true)]
    public static extern bool NanoApi_DeclareInstance(string typeName, out UIntPtr outPtr);
}
