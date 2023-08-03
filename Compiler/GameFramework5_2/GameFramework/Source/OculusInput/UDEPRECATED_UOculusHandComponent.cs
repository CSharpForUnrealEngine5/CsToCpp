#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OculusHandComponent.h")]
public partial class UDEPRECATED_UOculusHandComponent : UPoseableMeshComponent {
	public static UClass StaticClass() {return default;}
	///<summary>SkeletonType</summary>
	public EOculusHandType SkeletonType;
	///<summary>MeshType</summary>
	public EOculusHandType MeshType;
	///<summary>ConfidenceBehavior</summary>
	public EConfidenceBehavior ConfidenceBehavior;
	///<summary>SystemGestureBehavior</summary>
	public ESystemGestureBehavior SystemGestureBehavior;
	///<summary>SystemGestureMaterial</summary>
	public UMaterialInterface SystemGestureMaterial;
	///<summary>bInitializePhysics</summary>
	public bool bInitializePhysics;
	///<summary>bUpdateHandScale</summary>
	public bool bUpdateHandScale;
	///<summary>MaterialOverride</summary>
	public UMaterialInterface MaterialOverride;
	///<summary>BoneNameMappings</summary>
	public TMap<EBone,string> BoneNameMappings;
	///<summary>CollisionCapsules</summary>
	public TArray<FOculusCapsuleCollider> CollisionCapsules;
	///<summary>bSkeletalMeshInitialized</summary>
	public bool bSkeletalMeshInitialized;
}
