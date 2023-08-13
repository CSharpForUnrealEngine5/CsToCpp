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
