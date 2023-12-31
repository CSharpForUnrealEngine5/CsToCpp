namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MotionWarpingComponent.h")]
public partial class UMotionWarpingUtilities : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Extract Root Motion transform from a contiguous position range</summary>
	public static FTransform ExtractRootMotionFromAnimation(UAnimSequenceBase Animation,float StartTime,float EndTime) { return default; }
	///<summary>@return All the MotionWarping windows within the supplied animation</summary>
	public static void GetMotionWarpingWindowsFromAnimation(UAnimSequenceBase Animation,TArray<FMotionWarpingWindowData> OutWindows) {}
	///<summary>@return All the MotionWarping windows within the supplied animation for a given Warp Target</summary>
	public static void GetMotionWarpingWindowsForWarpTargetFromAnimation(UAnimSequenceBase Animation,FName WarpTargetName,TArray<FMotionWarpingWindowData> OutWindows) {}
}
