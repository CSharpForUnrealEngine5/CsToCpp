#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EyeTrackerTypes.h")]
///<summary>Stereo gaze data that contains information for each eye individually.</summary>
public partial struct FEyeTrackerStereoGazeData {
// EyeTrackerStereoGazeData
	public FVector LeftEyeOrigin;
	public FVector LeftEyeDirection;
	public FVector RightEyeOrigin;
	public FVector RightEyeDirection;
	public FVector FixationPoint;
	public float ConfidenceValue;
}
