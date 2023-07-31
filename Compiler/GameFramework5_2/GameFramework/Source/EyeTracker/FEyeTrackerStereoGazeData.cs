#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Stereo gaze data that contains information for each eye individually.</summary>
[CppInclude("EyeTrackerTypes.h")]
public partial struct FEyeTrackerStereoGazeData {
	public FVector LeftEyeOrigin;
	public FVector LeftEyeDirection;
	public FVector RightEyeOrigin;
	public FVector RightEyeDirection;
	public FVector FixationPoint;
	public float ConfidenceValue;
}
