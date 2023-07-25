#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MotionWarpingComponent.h")]
public partial class UMotionWarpingUtilities : UBlueprintFunctionLibrary {
// MotionWarpingUtilities
	public FTransform ExtractRootMotionFromAnimation(UObject Animation,float StartTime,float EndTime) { return default; }
	public void GetMotionWarpingWindowsFromAnimation(UObject Animation,TArray<FMotionWarpingWindowData> OutWindows) {}
	public void GetMotionWarpingWindowsForWarpTargetFromAnimation(UObject Animation,string WarpTargetName,TArray<FMotionWarpingWindowData> OutWindows) {}
}
