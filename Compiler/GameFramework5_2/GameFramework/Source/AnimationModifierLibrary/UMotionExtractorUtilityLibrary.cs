#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MotionExtractorUtilities.h")]
public partial class UMotionExtractorUtilityLibrary : UBlueprintFunctionLibrary {
// MotionExtractorUtilityLibrary
	public string GenerateCurveName(string BoneName,EMotionExtractor_MotionType MotionType,EMotionExtractor_Axis Axis) { return default; }
	public float GetDesiredValue(FTransform BoneTransform,FTransform LastBoneTransform,float DeltaTime,EMotionExtractor_MotionType MotionType,EMotionExtractor_Axis Axis) { return default; }
	public TArray<FVector2D> GetStoppedRangesFromRootMotion(UObject AnimSequence,float StopSpeedThreshold/*=10.0f*/,float SampleRate/*=120.0f*/) { return default; }
	public TArray<FVector2D> GetMovingRangesFromRootMotion(UObject AnimSequence,float StopSpeedThreshold/*=10.0f*/,float SampleRate/*=120.0f*/) { return default; }
}
