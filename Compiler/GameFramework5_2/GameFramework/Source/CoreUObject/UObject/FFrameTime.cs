#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UObject/NoExportTypes.h")]
///<summary>Represents a time by a context-free frame number, plus a sub frame value in the range [0:1).</summary>
public partial struct FFrameTime {
// FrameTime
	public FFrameNumber FrameNumber;
	public float SubFrame;
}
