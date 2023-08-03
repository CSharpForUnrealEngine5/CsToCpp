#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCOE/Nodes/CustomizableObjectNodeMeshMorph.h")]
public partial class UCustomizableObjectNodeMeshMorph : UCustomizableObjectNode {
	public static UClass StaticClass() {return default;}
	///<summary>MorphTargetName</summary>
	public string MorphTargetName;
	///<summary>Enable the deformation of the skeleton of the base mesh.</summary>
	public bool bReshapeSkeleton;
	///<summary>Enable the deformation of physics volumes of the base mesh</summary>
	public bool bReshapePhysicsVolumes;
	///<summary>Bone Reshape Selection Method</summary>
	public EBoneDeformSelectionMethod SelectionMethod;
	///<summary>Array with selected bones that will be deformed</summary>
	public TArray<FMeshReshapeBoneReference> BonesToDeform;
	///<summary>PhysicsSelectionMethod</summary>
	public EBoneDeformSelectionMethod PhysicsSelectionMethod;
	///<summary>Array with bones with physics bodies that will be deformed</summary>
	public TArray<FMeshReshapeBoneReference> PhysicsBodiesToDeform;
	///<summary>bDeformAllBones_DEPRECATED</summary>
	public bool bDeformAllBones_DEPRECATED;
	///<summary>bDeformAllPhysicsBodies_DEPRECATED</summary>
	public bool bDeformAllPhysicsBodies_DEPRECATED;
}
