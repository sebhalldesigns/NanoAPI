using System;
using NanoKit;
using NanoKit.System;

namespace NanoKit.System;

public class NObject
{
    private static UIntPtr typeHandle = 0;
    private UIntPtr handle = 0;

    public NObject()
    {
        NanoObject.GetSystemType<NObject>(typeHandle, out typeHandle);
    }   
}