#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARSkyLight.h")]
///<summary>This sky light class forces a refresh of the cube map data when an AR environment probe changes</summary>
public partial class AARSkyLight : ASkyLight {
// ARSkyLight
	public void SetEnvironmentCaptureProbe(UObject InCaptureProbe) {}
	public UAREnvironmentCaptureProbe CaptureProbe;
}
