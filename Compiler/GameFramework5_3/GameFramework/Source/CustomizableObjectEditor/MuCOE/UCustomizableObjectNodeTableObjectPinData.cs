namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for all Table Pins.</summary>
[CppInclude("MuCOE/Nodes/CustomizableObjectNodeTable.h")]
public partial class UCustomizableObjectNodeTableObjectPinData : UCustomizableObjectNodePinData {
	public static UClass StaticClass() {return default;}
	///<summary>Name of the data table column related to the pin</summary>
	public string ColumnName;
}
