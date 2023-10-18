namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>PinData of a pin that belongs to a Skeletal Mesh Section.</summary>
[CppInclude("MuCOE/Nodes/CustomizableObjectNodeSkeletalMesh.h")]
public partial class UCustomizableObjectNodeSkeletalMeshPinDataSection : UCustomizableObjectNodePinData {
	public static UClass StaticClass() {return default;}
	///<summary>LODIndex</summary>
	public int LODIndex;
	///<summary>SectionIndex</summary>
	public int SectionIndex;
}
