#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Highlevel/Hierarchy/RigUnit_AimBone.h")]
///<summary>Aligns the rotation of a primary and secondary axis of a bone to a global target.</summary>
public partial struct FRigUnit_AimItem {
// RigUnit_AimItem
	public FRigElementKey Item;
	public FRigUnit_AimItem_Target Primary;
	public FRigUnit_AimItem_Target Secondary;
	public float Weight;
	public FRigUnit_AimBone_DebugSettings DebugSettings;
	public FCachedRigElement CachedItem;
	public FCachedRigElement PrimaryCachedSpace;
	public FCachedRigElement SecondaryCachedSpace;
	public bool bIsInitialized;
}
