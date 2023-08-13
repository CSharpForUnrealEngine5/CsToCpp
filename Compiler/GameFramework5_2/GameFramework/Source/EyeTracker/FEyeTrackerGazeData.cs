namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Represents a unified gaze ray that incorporates both eyes.</summary>
[CppInclude("EyeTrackerTypes.h")]
public partial struct FEyeTrackerGazeData {
	public FVector GazeOrigin;
	public FVector GazeDirection;
	public FVector FixationPoint;
	public float ConfidenceValue;
	public bool bIsLeftEyeBlink;
	public bool bIsRightEyeBlink;
	public float LeftPupilDiameter;
	public float RightPupilDiameter;
}
