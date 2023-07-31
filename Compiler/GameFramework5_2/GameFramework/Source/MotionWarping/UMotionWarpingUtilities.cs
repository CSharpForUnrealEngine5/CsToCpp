#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MotionWarpingComponent.h")]
public partial class UMotionWarpingUtilities : UBlueprintFunctionLibrary {
	///<summary>Extract Root Motion transform from a contiguous position range</summary>
	public static FTransform ExtractRootMotionFromAnimation(UAnimSequenceBase Animation,float StartTime,float EndTime) { return default; }
	///<summary>@return All the MotionWarping windows within the supplied animation</summary>
	public static void GetMotionWarpingWindowsFromAnimation(UAnimSequenceBase Animation,TArray<FMotionWarpingWindowData> OutWindows) {}
	///<summary>@return All the MotionWarping windows within the supplied animation for a given Warp Target</summary>
	public static void GetMotionWarpingWindowsForWarpTargetFromAnimation(UAnimSequenceBase Animation,string WarpTargetName,TArray<FMotionWarpingWindowData> OutWindows) {}
}
