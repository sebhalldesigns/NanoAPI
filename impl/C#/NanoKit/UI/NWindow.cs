using System;
using NanoKit;
using NanoKit.System;

namespace NanoKit.UI;

public class NWindow: NObject
{

    private static UIntPtr typeHandle = 0;
    private UIntPtr handle = 0;

    public NanoParameter<int> Width;
    public NanoParameter<int> Height;

    public NWindow()
    {
        NanoObject.GetSystemType<NWindow>(typeHandle, out typeHandle);
        
        Width = new NanoParameter<int>(typeof(NWindow), "Width", 0);
        Height = new NanoParameter<int>(typeof(NWindow), "Height", 0);

        NanoObject.DeclareInstance<NWindow>(out handle);
    }   
}