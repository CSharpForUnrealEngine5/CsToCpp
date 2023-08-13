namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Converts the current system time to timecode, relative to a provided frame rate.</summary>
[CppInclude("Engine/SystemTimeTimecodeProvider.h")]
public partial class USystemTimeTimecodeProvider : UTimecodeProvider {
	public static UClass StaticClass() {return default;}
	///<summary>The frame rate at which the timecode value will be generated.</summary>
	public FFrameRate FrameRate;
	///<summary>When generating frame time, should we generate full frame without subframe value.</summary>
	public bool bGenerateFullFrame;
	///<summary>Use the high performance clock instead of the system time to generate the timecode value.</summary>
	public bool bUseHighPerformanceClock;
}
