namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A tracked environment texture probe that gives you a cube map for reflections</summary>
[CppInclude("ARTrackable.h")]
public partial class UAREnvironmentCaptureProbe : UARTrackedGeometry {
	public static UClass StaticClass() {return default;}
	///<summary>See: Extent</summary>
	public FVector GetExtent() { return default; }
	///<summary>See: EnvironmentCaptureTexture</summary>
	public UAREnvironmentCaptureProbeTexture GetEnvironmentCaptureTexture() { return default; }
	///<summary>The size of area this probe covers</summary>
	public FVector Extent;
	///<summary>The cube map of the reflected environment</summary>
	public UAREnvironmentCaptureProbeTexture EnvironmentCaptureTexture;
}
