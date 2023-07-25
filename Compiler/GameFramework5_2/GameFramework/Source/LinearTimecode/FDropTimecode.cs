#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DropTimecode.h")]
///<summary>Hold a frame of a Linear Timecode Frame</summary>
public partial struct FDropTimecode {
// DropTimecode
	public FTimecode Timecode;
	public int FrameRate;
	public bool bColorFraming;
	public bool bRunningForward;
	public bool bNewFrame;
}
