namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Additional data for a Mesh pins.</summary>
[CppInclude("MuCOE/Nodes/CustomizableObjectNodeTable.h")]
public partial class UCustomizableObjectNodeTableMeshPinData : UCustomizableObjectNodeTableObjectPinData {
	public static UClass StaticClass() {return default;}
	///<summary>Anim Instance Column name related to this Mesh pin</summary>
	public string AnimInstanceColumnName;
	///<summary>Anim Slot Column name related to this Mesh pin</summary>
	public string AnimSlotColumnName;
	///<summary>Anim Tag Column name related to this Mesh pin</summary>
	public string AnimTagColumnName;
	///<summary>MutableColumnName</summary>
	public string MutableColumnName;
	///<summary>LOD of the mesh related to this Mesh pin</summary>
	public int LOD;
	///<summary>Material Index (Surface Index) of the mesh related to this Mesh pin</summary>
	public int Material;
	///<summary>Layouts related to this Mesh pin</summary>
	public TArray<UCustomizableObjectLayout> Layouts;
}
