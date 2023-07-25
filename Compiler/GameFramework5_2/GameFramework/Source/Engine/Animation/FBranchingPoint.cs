#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimMontage.h")]
///<summary>Remove FBranchingPoint when VER_UE4_MONTAGE_BRANCHING_POINT_REMOVAL is removed.</summary>
public partial struct FBranchingPoint {
// BranchingPoint
	public string EventName;
	public float DisplayTime_DEPRECATED;
	public float TriggerTimeOffset;
}
