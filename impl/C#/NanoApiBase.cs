using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace NanoApi;

public class NanoApiBase
{
    
   public NanoApiBase()
   {
        IntPtr handle = NativeLibrary.Load("libNanoApi.dll");
        if (handle == IntPtr.Zero)
        {
            int errorCode = Marshal.GetLastWin32Error();
            throw new Exception(string.Format("Failed to load library (ErrorCode: {0})", errorCode));
        }   

        NanoApiLibrary.NANOAPI_TX(new NanoApi.nApiBuffer());
        NanoApiLibrary.NANOAPI_RX();
        NanoApiLibrary.NANOAPI_CLK();
   }
}
