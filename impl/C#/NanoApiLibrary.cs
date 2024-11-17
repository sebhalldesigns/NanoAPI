using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace NanoApi;

public struct nApiBuffer
{
    public UIntPtr length;
    public UIntPtr data;
}

public static class NanoApiLibrary
{
    [DllImport("libNanoApi.dll", SetLastError = true)]
    public static extern void NANOAPI_TX(nApiBuffer buffer);

    [DllImport("libNanoApi.dll", SetLastError = true)]
    public static extern nApiBuffer NANOAPI_RX();

    [DllImport("libNanoApi.dll", SetLastError = true)]
    public static extern void NANOAPI_CLK();

}
