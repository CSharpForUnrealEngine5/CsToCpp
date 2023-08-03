#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Pose matching cost for the continuing pose will be affected by this, making the animation segment more or less</summary>
[CppInclude("PoseSearch/PoseSearchAnimNotifies.h")]
public partial class UAnimNotifyState_PoseSearchOverrideContinuingPoseCostBias : UAnimNotifyState_PoseSearchBase {
	public static UClass StaticClass() {return default;}
	///<summary>A negative value reduces the cost and makes the segment more likely to continuing playing. A positive value, conversely,</summary>
	public float CostAddend;
}
