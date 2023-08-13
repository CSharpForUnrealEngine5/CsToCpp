namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARTrackable.h")]
public partial class UARTrackedImage : UARTrackedGeometry {
	public static UClass StaticClass() {return default;}
	///<summary>See: DetectedImage</summary>
	public UARCandidateImage GetDetectedImage() { return default; }
	///<summary>* Get the estimate size of the detected image, where X is the estimated width, and Y is the estimated height.</summary>
	public FVector2D GetEstimateSize() { return default; }
	///<summary>The candidate image that was detected in the scene</summary>
	public UARCandidateImage DetectedImage;
	///<summary>The estimated image size that was detected in the scene</summary>
	public FVector2D EstimatedSize;
}
