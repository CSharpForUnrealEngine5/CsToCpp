#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCOE/Nodes/CustomizableObjectNodeMeshClipWithMesh.h")]
public partial class UCustomizableObjectNodeMeshClipWithMesh : UCustomizableObjectNodeModifierBase {
// CustomizableObjectNodeMeshClipWithMesh
	public TArray<string> Tags;
	public UCustomizableObject CustomizableObjectToClipWith;
	public TArray<FGuid> ArrayMaterialNodeToClipWithID;
	public FTransform Transform;
}
