#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCOE/Nodes/CustomizableObjectNodeTable.h")]
///<summary>Additional data for a Mesh pins.</summary>
public partial class UCustomizableObjectNodeTableMeshPinData : UCustomizableObjectNodeTableObjectPinData {
// CustomizableObjectNodeTableMeshPinData
	public string AnimInstanceColumnName;
	public string AnimSlotColumnName;
	public string AnimTagColumnName;
	public string MutableColumnName;
	public int LOD;
	public int Material;
	public TArray<UCustomizableObjectLayout> Layouts;
}
