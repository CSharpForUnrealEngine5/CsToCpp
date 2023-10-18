namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Area of the image that the computer vision task detected as being a face</summary>
[CppInclude("AppleVisionTypes.h")]
public partial struct FDetectedFace {
	public FBox2D BoundingBox;
	public TArray<FDetectedFaceFeature2D> Features;
	public TArray<FDetectedFaceFeatureRegion> FeatureRegions;
}
