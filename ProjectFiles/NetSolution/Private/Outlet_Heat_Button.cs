using System;
using UAManagedCore;

//-------------------------------------------
// WARNING: AUTO-GENERATED CODE, DO NOT EDIT!
//-------------------------------------------

[MapType(NamespaceUri = "HMI_6040_RMS", Guid = "54839ad7f435d8751d41a734956d8d23")]
public class Outlet_Heat_Button : FTOptix.CoreBase.ValueMapConverter
{
#region Children properties
    //-------------------------------------------
    // WARNING: AUTO-GENERATED CODE, DO NOT EDIT!
    //-------------------------------------------
    public UAManagedCore.IUAObject Pairs
    {
        get
        {
            return (UAManagedCore.IUAObject)Refs.GetObject("Pairs");
        }
    }
#endregion
}
