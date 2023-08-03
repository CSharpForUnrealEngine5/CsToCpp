#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCOE/Nodes/CustomizableObjectNodeMeshClipWithMesh.h")]
public partial class UCustomizableObjectNodeMeshClipWithMesh : UCustomizableObjectNodeModifierBase {
	public static UClass StaticClass() {return default;}
	///<summary>Tags</summary>
	public TArray<string> Tags;
	///<summary>!&lt; If assigned, then a material inside this CO will be clipped by this node.</summary>
	public UCustomizableObject CustomizableObjectToClipWith;
	///<summary>!&lt; Array with the Guids of the nodes with the same material inside the CustomizableObjectToClipWith CO (if any is assigned)</summary>
	public TArray<FGuid> ArrayMaterialNodeToClipWithID;
	///<summary>Mesh Transform</summary>
	public FTransform Transform;
}
