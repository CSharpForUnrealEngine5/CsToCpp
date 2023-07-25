#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/SystemTimeTimecodeProvider.h")]
///<summary>Converts the current system time to timecode, relative to a provided frame rate.</summary>
public partial class USystemTimeTimecodeProvider : UTimecodeProvider {
// SystemTimeTimecodeProvider
	public FFrameRate FrameRate;
	public bool bGenerateFullFrame;
	public bool bUseHighPerformanceClock;
}
