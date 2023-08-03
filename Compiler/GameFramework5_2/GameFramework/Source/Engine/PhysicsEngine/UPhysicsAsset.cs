#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>PhysicsAsset contains a set of rigid bodies and constraints that make up a single ragdoll.</summary>
[CppInclude("PhysicsEngine/PhysicsAsset.h")]
public partial class UPhysicsAsset : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Default skeletal mesh to use when previewing this PhysicsAsset etc.</summary>
	public USkeletalMesh DefaultSkelMesh_DEPRECATED;
	///<summary>PreviewSkeletalMesh</summary>
	public TSoftObjectPtr<USkeletalMesh> PreviewSkeletalMesh;
	///<summary>PhysicalAnimationProfiles</summary>
	public TArray<string> PhysicalAnimationProfiles;
	///<summary>ConstraintProfiles</summary>
	public TArray<string> ConstraintProfiles;
	///<summary>CurrentPhysicalAnimationProfileName</summary>
	public string CurrentPhysicalAnimationProfileName;
	///<summary>CurrentConstraintProfileName</summary>
	public string CurrentConstraintProfileName;
	///<summary>Index of bodies that are marked bConsiderForBounds</summary>
	public TArray<int> BoundsBodies;
	///<summary>Array of SkeletalBodySetup objects. Stores information about collision shape etc. for each body.</summary>
	public TArray<USkeletalBodySetup> SkeletalBodySetups;
	///<summary>Array of RB_ConstraintSetup objects.</summary>
	public TArray<UPhysicsConstraintTemplate> ConstraintSetup;
	///<summary>Solver settings when the asset is used with a RigidBody Anim Node (RBAN).</summary>
	public FPhysicsAssetSolverSettings SolverSettings;
	///<summary>Old solver settings shown for reference. These will be removed at some point.</summary>
	public FSolverIterations SolverIterations;
	///<summary>Solver type used in physics asset editor. This can be used to make what you see in the asset editror more closely resembles what you</summary>
	public EPhysicsAssetSolverType SolverType;
	///<summary>If true, we skip instancing bodies for this PhysicsAsset on dedicated servers</summary>
	public bool bNotForDedicatedServer;
	///<summary>Information for thumbnail rendering</summary>
	public UThumbnailInfo ThumbnailInfo;
	///<summary>Gets a constraint by its joint name</summary>
	public  FConstraintInstanceAccessor GetConstraintByName(string ConstraintName) { return default; }
	///<summary>Gets a constraint by its joint name</summary>
	public  FConstraintInstanceAccessor GetConstraintByBoneNames(string Bone1Name,string Bone2Name) { return default; }
	///<summary>Gets all constraints</summary>
	public  void GetConstraints(bool bIncludesTerminated,TArray<FConstraintInstanceAccessor> OutConstraints) {}
	///<summary>BodySetup_DEPRECATED</summary>
	public TArray<UBodySetup> BodySetup_DEPRECATED;
}
