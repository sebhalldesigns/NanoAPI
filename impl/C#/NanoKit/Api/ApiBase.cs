using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace NanoKit.Api;

public class ApiBase
{
    
   public ApiBase()
   {
        IntPtr handle = NativeLibrary.Load("libNanoApi.dll");
        if (handle == IntPtr.Zero)
        {
            int errorCode = Marshal.GetLastWin32Error();
            throw new Exception(string.Format("Failed to load library (ErrorCode: {0})", errorCode));
        }   
   }
}
