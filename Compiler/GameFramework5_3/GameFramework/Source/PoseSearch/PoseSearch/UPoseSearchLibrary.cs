namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PoseSearch/PoseSearchLibrary.h")]
public partial class UPoseSearchLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Implementation of the core motion matching algorithm</summary>
	public static void MotionMatch(UAnimInstance AnimInstance,UPoseSearchDatabase Database,FPoseSearchQueryTrajectory Trajectory,float TrajectorySpeedMultiplier,FName PoseHistoryName,UAnimationAsset SelectedAnimation,float SelectedTime,bool bLoop,bool bIsMirrored,FVector BlendParameters,float SearchCost,UAnimationAsset FutureAnimation/*=nullptr*/,float FutureAnimationStartTime/*=0.0f*/,float TimeToFutureAnimationStart/*=0.0f*/,int DebugSessionUniqueIdentifier/*=6174*/) {}
}
