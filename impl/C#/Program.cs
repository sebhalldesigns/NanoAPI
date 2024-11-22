using System;
using NanoKit.System;
using NanoKit;
using NanoKit.UI;

public class CustomWindow: NWindow
{
    private static UIntPtr typeHandle = 0;
    private UIntPtr handle = 0;

    public CustomWindow()
    {
        NanoObject.DeclareCustomType<CustomWindow, NWindow>(typeHandle, out typeHandle);
        NanoObject.DeclareInstance<CustomWindow>(out handle);
    }
}

public class CustomDerivedWindow: CustomWindow
{
    private static UIntPtr typeHandle = 0;
    private UIntPtr handle = 0;

    public CustomDerivedWindow()
    {
        NanoObject.DeclareCustomType<CustomDerivedWindow, CustomWindow>(typeHandle, out typeHandle);
        NanoObject.DeclareInstance<CustomDerivedWindow>(out handle);
    }
}

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("NANOAPI TEST");

        // Load the library
        NanoKit.Api.ApiBase nanoApi = new NanoKit.Api.ApiBase();

        //NanoObject nanoObject = new NanoObject();
        //NanoParameter<int> nanoParameter = new NanoParameter<int>();

        CustomWindow window = new CustomWindow();

        CustomDerivedWindow derivedWindow = new CustomDerivedWindow();
    }
}