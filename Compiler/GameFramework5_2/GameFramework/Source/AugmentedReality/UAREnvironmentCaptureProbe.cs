#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARTrackable.h")]
///<summary>A tracked environment texture probe that gives you a cube map for reflections</summary>
public partial class UAREnvironmentCaptureProbe : UARTrackedGeometry {
// AREnvironmentCaptureProbe
	public FVector GetExtent() { return default; }
	public UObject GetEnvironmentCaptureTexture() { return default; }
	public FVector Extent;
	public UAREnvironmentCaptureProbeTexture EnvironmentCaptureTexture;
}
