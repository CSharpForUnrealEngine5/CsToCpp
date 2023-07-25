#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tools/MotionTrailOptions.h")]
///<summary>TODO: option to make tick size proportional to distance from camera to get a sense of perspective and scale</summary>
public partial class UMotionTrailToolOptions : UObject {
// MotionTrailToolOptions
	public bool bShowTrails;
	public FLinearColor TrailColor;
	public bool bShowFullTrail;
	public float TrailThickness;
	public int FramesBefore;
	public int FramesAfter;
	public int EvalsPerFrame;
	public bool bShowKeys;
	public bool bShowFrameNumber;
	public FLinearColor KeyColor;
	public double KeySize;
	public bool bShowMarks;
	public FLinearColor MarkColor;
	public double MarkSize;
	public bool bLockMarksToFrames;
	public double SecondsPerMark;
}
