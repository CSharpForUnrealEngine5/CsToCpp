namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Area of the image that the computer vision task detected as being of a particular type</summary>
[CppInclude("AppleVisionTypes.h")]
public partial struct FDetectedFeatureRegion {
	public TArray<FVector2D> Points;
}
