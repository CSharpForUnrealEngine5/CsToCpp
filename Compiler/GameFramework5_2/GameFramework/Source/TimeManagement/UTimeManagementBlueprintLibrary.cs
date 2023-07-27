#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TimeManagementBlueprintLibrary.h")]
public partial class UTimeManagementBlueprintLibrary : UBlueprintFunctionLibrary {
// TimeManagementBlueprintLibrary
	public static float Conv_FrameRateToSeconds(FFrameRate InFrameRate) { return default; }
	public static float Conv_QualifiedFrameTimeToSeconds(FQualifiedFrameTime InFrameTime) { return default; }
	public static FFrameTime Multiply_SecondsFrameRate(float TimeInSeconds,FFrameRate FrameRate) { return default; }
	public static string Conv_TimecodeToString(FTimecode InTimecode,bool bForceSignDisplay/*=false*/) { return default; }
	public static bool IsValid_Framerate(FFrameRate InFrameRate) { return default; }
	public static bool IsValid_MultipleOf(FFrameRate InFrameRate,FFrameRate OtherFramerate) { return default; }
	public static FFrameTime TransformTime(FFrameTime SourceTime,FFrameRate SourceRate,FFrameRate DestinationRate) { return default; }
	public static FFrameTime SnapFrameTimeToRate(FFrameTime SourceTime,FFrameRate SourceRate,FFrameRate SnapToRate) { return default; }
	public static FFrameNumber Add_FrameNumberFrameNumber(FFrameNumber A,FFrameNumber B) { return default; }
	public static FFrameNumber Subtract_FrameNumberFrameNumber(FFrameNumber A,FFrameNumber B) { return default; }
	public static FFrameNumber Add_FrameNumberInteger(FFrameNumber A,int B) { return default; }
	public static FFrameNumber Subtract_FrameNumberInteger(FFrameNumber A,int B) { return default; }
	public static FFrameNumber Multiply_FrameNumberInteger(FFrameNumber A,int B) { return default; }
	public static FFrameNumber Divide_FrameNumberInteger(FFrameNumber A,int B) { return default; }
	public static int Conv_FrameNumberToInteger(FFrameNumber InFrameNumber) { return default; }
	public static FTimecode GetTimecode() { return default; }
	public static FFrameRate GetTimecodeFrameRate() { return default; }
}
