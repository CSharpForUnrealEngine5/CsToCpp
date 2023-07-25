#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/SkyLight.h")]
public partial class ASkyLight : AInfo {
// SkyLight
	public USkyLightComponent LightComponent;
	public bool bEnabled;
	public void OnRep_bEnabled() {}
}
