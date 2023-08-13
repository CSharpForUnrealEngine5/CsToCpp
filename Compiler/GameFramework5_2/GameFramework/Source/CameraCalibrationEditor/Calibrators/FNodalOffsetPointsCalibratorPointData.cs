namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds information of the identified calibrator 2d point for a given sample of a 2d-3d correlation</summary>
[CppInclude("Calibrators/CameraNodalOffsetAlgoPoints.h")]
public partial struct FNodalOffsetPointsCalibratorPointData {
	public bool bIsValid;
	public string Name;
	public FVector Location;
}
