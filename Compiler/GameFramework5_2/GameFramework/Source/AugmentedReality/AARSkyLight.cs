#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This sky light class forces a refresh of the cube map data when an AR environment probe changes</summary>
[CppInclude("ARSkyLight.h")]
public partial class AARSkyLight : ASkyLight {
	public static UClass StaticClass() {return default;}
	///<summary>Sets the environment capture probe that this sky light is driven by</summary>
	public  void SetEnvironmentCaptureProbe(UAREnvironmentCaptureProbe InCaptureProbe) {}
	///<summary>CaptureProbe</summary>
	public UAREnvironmentCaptureProbe CaptureProbe;
}
