namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MotionExtractorUtilities.h")]
public partial class UMotionExtractorUtilityLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Generates a curve name based on input settings.</summary>
	public static FName GenerateCurveName(FName BoneName,EMotionExtractor_MotionType MotionType,EMotionExtractor_Axis Axis) { return default; }
	///<summary>Returns the desired value from the extracted poses based on input settings.</summary>
	public static float GetDesiredValue(FTransform BoneTransform,FTransform LastBoneTransform,float DeltaTime,EMotionExtractor_MotionType MotionType,EMotionExtractor_Axis Axis) { return default; }
	///<summary>Returns the ranges (X/Start to Y/End) in the specified animation sequence where the animation is considered stopped.</summary>
	public static TArray<FVector2D> GetStoppedRangesFromRootMotion(UAnimSequence AnimSequence,float StopSpeedThreshold/*=10.0f*/,float SampleRate/*=120.0f*/) { return default; }
	///<summary>Returns the ranges (X/Start to Y/End) in the specified animation sequence where the animation is considered moving.</summary>
	public static TArray<FVector2D> GetMovingRangesFromRootMotion(UAnimSequence AnimSequence,float StopSpeedThreshold/*=10.0f*/,float SampleRate/*=120.0f*/) { return default; }
}
