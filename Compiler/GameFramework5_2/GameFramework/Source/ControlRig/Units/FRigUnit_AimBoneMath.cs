#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Outputs an aligned transform of a primary and secondary axis of an input transform to a world target.</summary>
[CppInclude("Units/Highlevel/Hierarchy/RigUnit_AimBone.h")]
public partial struct FRigUnit_AimBoneMath {
	public FTransform InputTransform;
	public FRigUnit_AimItem_Target Primary;
	public FRigUnit_AimItem_Target Secondary;
	public float Weight;
	public FTransform Result;
	public FRigUnit_AimBone_DebugSettings DebugSettings;
	public FCachedRigElement PrimaryCachedSpace;
	public FCachedRigElement SecondaryCachedSpace;
	public bool bIsInitialized;
}
