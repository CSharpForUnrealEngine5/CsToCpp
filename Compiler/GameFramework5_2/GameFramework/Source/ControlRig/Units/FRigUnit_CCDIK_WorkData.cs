#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Highlevel/Hierarchy/RigUnit_CCDIK.h")]
public partial struct FRigUnit_CCDIK_WorkData {
// RigUnit_CCDIK_WorkData
	public TArray<FCCDIKChainLink> Chain;
	public TArray<FCachedRigElement> CachedItems;
	public TArray<int> RotationLimitIndex;
	public TArray<float> RotationLimitsPerItem;
	public FCachedRigElement CachedEffector;
}
