#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EyeTrackerTypes.h")]
///<summary>Represents a unified gaze ray that incorporates both eyes.</summary>
public partial struct FEyeTrackerGazeData {
// EyeTrackerGazeData
	public FVector GazeOrigin;
	public FVector GazeDirection;
	public FVector FixationPoint;
	public float ConfidenceValue;
	public bool bIsLeftEyeBlink;
	public bool bIsRightEyeBlink;
	public float LeftPupilDiameter;
	public float RightPupilDiameter;
}
