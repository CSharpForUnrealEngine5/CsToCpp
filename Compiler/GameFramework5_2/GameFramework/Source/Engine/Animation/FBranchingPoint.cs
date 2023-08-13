namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Remove FBranchingPoint when VER_UE4_MONTAGE_BRANCHING_POINT_REMOVAL is removed.</summary>
[CppInclude("Animation/AnimMontage.h")]
public partial struct FBranchingPoint {
	public string EventName;
	public float DisplayTime_DEPRECATED;
	public float TriggerTimeOffset;
}
