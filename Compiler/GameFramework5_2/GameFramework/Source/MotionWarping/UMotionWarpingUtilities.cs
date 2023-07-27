#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MotionWarpingComponent.h")]
public partial class UMotionWarpingUtilities : UBlueprintFunctionLibrary {
// MotionWarpingUtilities
	public static FTransform ExtractRootMotionFromAnimation(UAnimSequenceBase Animation,float StartTime,float EndTime) { return default; }
	public static void GetMotionWarpingWindowsFromAnimation(UAnimSequenceBase Animation,TArray<FMotionWarpingWindowData> OutWindows) {}
	public static void GetMotionWarpingWindowsForWarpTargetFromAnimation(UAnimSequenceBase Animation,string WarpTargetName,TArray<FMotionWarpingWindowData> OutWindows) {}
}
