#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OculusHandComponent.h")]
public partial class UDEPRECATED_UOculusHandComponent : UPoseableMeshComponent {
// UOculusHandComponent
	public EOculusHandType SkeletonType;
	public EOculusHandType MeshType;
	public EConfidenceBehavior ConfidenceBehavior;
	public ESystemGestureBehavior SystemGestureBehavior;
	public UMaterialInterface SystemGestureMaterial;
	public bool bInitializePhysics;
	public bool bUpdateHandScale;
	public UMaterialInterface MaterialOverride;
	public TMap<EBone,string> BoneNameMappings;
	public TArray<FOculusCapsuleCollider> CollisionCapsules;
	public bool bSkeletalMeshInitialized;
}
