#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>TODO: option to make tick size proportional to distance from camera to get a sense of perspective and scale</summary>
[CppInclude("Tools/MotionTrailOptions.h")]
public partial class UMotionTrailToolOptions : UObject {
	///<summary>bShowTrails</summary>
	public bool bShowTrails;
	///<summary>TrailColor</summary>
	public FLinearColor TrailColor;
	///<summary>bShowFullTrail</summary>
	public bool bShowFullTrail;
	///<summary>TrailThickness</summary>
	public float TrailThickness;
	///<summary>FramesBefore</summary>
	public int FramesBefore;
	///<summary>FramesAfter</summary>
	public int FramesAfter;
	///<summary>EvalsPerFrame</summary>
	public int EvalsPerFrame;
	///<summary>bShowKeys</summary>
	public bool bShowKeys;
	///<summary>bShowFrameNumber</summary>
	public bool bShowFrameNumber;
	///<summary>KeyColor</summary>
	public FLinearColor KeyColor;
	///<summary>KeySize</summary>
	public double KeySize;
	///<summary>bShowMarks</summary>
	public bool bShowMarks;
	///<summary>MarkColor</summary>
	public FLinearColor MarkColor;
	///<summary>MarkSize</summary>
	public double MarkSize;
	///<summary>bLockMarksToFrames</summary>
	public bool bLockMarksToFrames;
	///<summary>SecondsPerMark</summary>
	public double SecondsPerMark;
}
