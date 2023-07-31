#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Aligns the rotation of a primary and secondary axis of a bone to a global target.</summary>
[CppInclude("Units/Highlevel/Hierarchy/RigUnit_AimBone.h")]
public partial struct FRigUnit_AimBone {
	public string Bone;
	public FRigUnit_AimBone_Target Primary;
	public FRigUnit_AimBone_Target Secondary;
	public float Weight;
	public bool bPropagateToChildren;
	public FRigUnit_AimBone_DebugSettings DebugSettings;
	public FCachedRigElement CachedBoneIndex;
	public FCachedRigElement PrimaryCachedSpace;
	public FCachedRigElement SecondaryCachedSpace;
	public bool bIsInitialized;
}
