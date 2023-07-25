#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AppleVisionTypes.h")]
///<summary>Area of the image that the computer vision task detected as being a face</summary>
public partial struct FDetectedFace {
// DetectedFace
	public FBox2D BoundingBox;
	public TArray<FDetectedFaceFeature2D> Features;
	public TArray<FDetectedFaceFeatureRegion> FeatureRegions;
}
