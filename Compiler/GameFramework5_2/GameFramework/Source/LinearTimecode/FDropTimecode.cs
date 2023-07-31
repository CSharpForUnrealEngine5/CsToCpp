#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Hold a frame of a Linear Timecode Frame</summary>
[CppInclude("DropTimecode.h")]
public partial struct FDropTimecode {
	public FTimecode Timecode;
	public int FrameRate;
	public bool bColorFraming;
	public bool bRunningForward;
	public bool bNewFrame;
}
