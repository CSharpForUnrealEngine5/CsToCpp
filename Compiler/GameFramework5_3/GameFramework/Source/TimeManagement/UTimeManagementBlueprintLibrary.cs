namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TimeManagementBlueprintLibrary.h")]
public partial class UTimeManagementBlueprintLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Conv_FrameRateToSeconds</summary>
	public static float Conv_FrameRateToSeconds(FFrameRate InFrameRate) { return default; }
	///<summary>Converts a FrameRate to an interval float representing the frame time in seconds ie: 1/30 returns 0.0333333</summary>
	public static float Conv_FrameRateToInterval(FFrameRate InFrameRate) { return default; }
	///<summary>Converts an QualifiedFrameTime to seconds.</summary>
	public static float Conv_QualifiedFrameTimeToSeconds(FQualifiedFrameTime InFrameTime) { return default; }
	///<summary>Multiplies a value in seconds against a FrameRate to get a new FrameTime.</summary>
	public static FFrameTime Multiply_SecondsFrameRate(float TimeInSeconds,FFrameRate FrameRate) { return default; }
	///<summary>Converts an Timecode to a string (hh:mm:ss:ff). If bForceSignDisplay then the number sign will always be prepended instead of just when expressing a negative time.</summary>
	public static string Conv_TimecodeToString(FTimecode InTimecode,bool bForceSignDisplay/*=false*/) { return default; }
	///<summary>Verifies that this is a valid framerate with a non-zero denominator.</summary>
	public static bool IsValid_Framerate(FFrameRate InFrameRate) { return default; }
	///<summary>Checks if this framerate is an even multiple of another framerate, ie: 60 is a multiple of 30, but 59.94 is not.</summary>
	public static bool IsValid_MultipleOf(FFrameRate InFrameRate,FFrameRate OtherFramerate) { return default; }
	///<summary>Converts the specified time from one framerate to another framerate. This is useful for converting between tick resolution and display rate.</summary>
	public static FFrameTime TransformTime(FFrameTime SourceTime,FFrameRate SourceRate,FFrameRate DestinationRate) { return default; }
	///<summary>Snaps the given SourceTime to the nearest frame in the specified Destination Framerate. Useful for determining the nearest frame for another resolution. Returns the frame time in the destination frame rate.</summary>
	public static FFrameTime SnapFrameTimeToRate(FFrameTime SourceTime,FFrameRate SourceRate,FFrameRate SnapToRate) { return default; }
	///<summary>Addition (FrameNumber A + FrameNumber B)</summary>
	public static FFrameNumber Add_FrameNumberFrameNumber(FFrameNumber A,FFrameNumber B) { return default; }
	///<summary>Subtraction (FrameNumber A - FrameNumber B)</summary>
	public static FFrameNumber Subtract_FrameNumberFrameNumber(FFrameNumber A,FFrameNumber B) { return default; }
	///<summary>Addition (FrameNumber A + int B)</summary>
	public static FFrameNumber Add_FrameNumberInteger(FFrameNumber A,int B) { return default; }
	///<summary>Subtraction (FrameNumber A - int B)</summary>
	public static FFrameNumber Subtract_FrameNumberInteger(FFrameNumber A,int B) { return default; }
	///<summary>Multiply (FrameNumber A * B)</summary>
	public static FFrameNumber Multiply_FrameNumberInteger(FFrameNumber A,int B) { return default; }
	///<summary>Divide (FrameNumber A / B)</summary>
	public static FFrameNumber Divide_FrameNumberInteger(FFrameNumber A,int B) { return default; }
	///<summary>Converts a FrameNumber to an int32 for use in functions that take int32 frame counts for convenience.</summary>
	public static int Conv_FrameNumberToInteger(FFrameNumber InFrameNumber) { return default; }
	///<summary>Get the current timecode of the engine.</summary>
	public static FTimecode GetTimecode() { return default; }
	///<summary>Gets the current timecode frame rate.</summary>
	public static FFrameRate GetTimecodeFrameRate() { return default; }
}
