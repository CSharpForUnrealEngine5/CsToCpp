#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCOE/Nodes/CustomizableObjectNodeMeshMorph.h")]
public partial class UCustomizableObjectNodeMeshMorph : UCustomizableObjectNode {
// CustomizableObjectNodeMeshMorph
	public string MorphTargetName;
	public bool bReshapeSkeleton;
	public bool bReshapePhysicsVolumes;
	public EBoneDeformSelectionMethod SelectionMethod;
	public TArray<FMeshReshapeBoneReference> BonesToDeform;
	public EBoneDeformSelectionMethod PhysicsSelectionMethod;
	public TArray<FMeshReshapeBoneReference> PhysicsBodiesToDeform;
	public bool bDeformAllBones_DEPRECATED;
	public bool bDeformAllPhysicsBodies_DEPRECATED;
}
