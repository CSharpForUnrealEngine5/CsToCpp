#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A struct describes the ARCore light estimation.</summary>
[CppInclude("GoogleARCoreTypes.h")]
public partial struct FGoogleARCoreLightEstimate {
	public bool bIsValid;
	public float PixelIntensity;
	public FVector RGBScaleFactor;
}
