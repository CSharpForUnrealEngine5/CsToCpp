#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Highlevel/Hierarchy/RigUnit_AimBone.h")]
///<summary>Outputs an aligned transform of a primary and secondary axis of an input transform to a world target.</summary>
public partial struct FRigUnit_AimBoneMath {
// RigUnit_AimBoneMath
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
