#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TimeManagementBlueprintLibrary.h")]
public partial class UTimeManagementBlueprintLibrary : UBlueprintFunctionLibrary {
// TimeManagementBlueprintLibrary
	public float Conv_FrameRateToSeconds(FFrameRate InFrameRate) { return default; }
	public float Conv_QualifiedFrameTimeToSeconds(FQualifiedFrameTime InFrameTime) { return default; }
	public FFrameTime Multiply_SecondsFrameRate(float TimeInSeconds,FFrameRate FrameRate) { return default; }
	public string Conv_TimecodeToString(FTimecode InTimecode,bool bForceSignDisplay/*=false*/) { return default; }
	public bool IsValid_Framerate(FFrameRate InFrameRate) { return default; }
	public bool IsValid_MultipleOf(FFrameRate InFrameRate,FFrameRate OtherFramerate) { return default; }
	public FFrameTime TransformTime(FFrameTime SourceTime,FFrameRate SourceRate,FFrameRate DestinationRate) { return default; }
	public FFrameTime SnapFrameTimeToRate(FFrameTime SourceTime,FFrameRate SourceRate,FFrameRate SnapToRate) { return default; }
	public FFrameNumber Add_FrameNumberFrameNumber(FFrameNumber A,FFrameNumber B) { return default; }
	public FFrameNumber Subtract_FrameNumberFrameNumber(FFrameNumber A,FFrameNumber B) { return default; }
	public FFrameNumber Add_FrameNumberInteger(FFrameNumber A,int B) { return default; }
	public FFrameNumber Subtract_FrameNumberInteger(FFrameNumber A,int B) { return default; }
	public FFrameNumber Multiply_FrameNumberInteger(FFrameNumber A,int B) { return default; }
	public FFrameNumber Divide_FrameNumberInteger(FFrameNumber A,int B) { return default; }
	public int Conv_FrameNumberToInteger(FFrameNumber InFrameNumber) { return default; }
	public FTimecode GetTimecode() { return default; }
	public FFrameRate GetTimecodeFrameRate() { return default; }
}
