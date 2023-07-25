#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARTrackable.h")]
public partial class UARTrackedImage : UARTrackedGeometry {
// ARTrackedImage
	public UObject GetDetectedImage() { return default; }
	public FVector2D GetEstimateSize() { return default; }
	public UARCandidateImage DetectedImage;
	public FVector2D EstimatedSize;
}
