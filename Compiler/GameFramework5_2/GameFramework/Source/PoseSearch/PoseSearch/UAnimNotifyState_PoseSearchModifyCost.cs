#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Pose matching cost will be affected by this, making the animation segment more or less likely to be selected based</summary>
[CppInclude("PoseSearch/PoseSearchAnimNotifies.h")]
public partial class UAnimNotifyState_PoseSearchModifyCost : UAnimNotifyState_PoseSearchBase {
	public static UClass StaticClass() {return default;}
	///<summary>A negative value reduces the cost and makes the segment more likely to be chosen. A positive value, conversely,</summary>
	public float CostAddend;
}
