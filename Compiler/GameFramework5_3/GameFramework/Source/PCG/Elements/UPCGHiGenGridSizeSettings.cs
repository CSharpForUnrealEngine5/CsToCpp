namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Set the execution grid size for downstream nodes. Enables executing a single graph across a hierarchy of grids.</summary>
[CppInclude("Elements/PCGHiGenGridSize.h")]
public partial class UPCGHiGenGridSizeSettings : UPCGSettings {
	public static UClass StaticClass() {return default;}
	///<summary>HiGenGridSize</summary>
	public EPCGHiGenGrid HiGenGridSize;
}
