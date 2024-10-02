using System;
using UAManagedCore;

//-------------------------------------------
// WARNING: AUTO-GENERATED CODE, DO NOT EDIT!
//-------------------------------------------

[MapType(NamespaceUri = "HMI_6040_RMS", Guid = "da67bed68762015b801456ca4517b6ec")]
public class inlet_heat_on_off : FTOptix.CoreBase.ValueMapConverter
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
