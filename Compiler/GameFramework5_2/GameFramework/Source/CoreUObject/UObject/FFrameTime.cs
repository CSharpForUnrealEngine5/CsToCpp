#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Represents a time by a context-free frame number, plus a sub frame value in the range [0:1).</summary>
[CppInclude("UObject/NoExportTypes.h")]
public partial struct FFrameTime {
	public FFrameNumber FrameNumber;
	public float SubFrame;
}
