namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Aligns the rotation of a primary and secondary axis of a bone to a global target.</summary>
[CppInclude("Units/Highlevel/Hierarchy/RigUnit_AimBone.h")]
public partial struct FRigUnit_AimItem {
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
