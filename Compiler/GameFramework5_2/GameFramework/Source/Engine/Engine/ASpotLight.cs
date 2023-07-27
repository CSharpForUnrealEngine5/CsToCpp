#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/SpotLight.h")]
public partial class ASpotLight : ALight {
// SpotLight
	public USpotLightComponent SpotLightComponent;
	public UArrowComponent ArrowComponent;
	public  void SetInnerConeAngle(float NewInnerConeAngle) {}
	public  void SetOuterConeAngle(float NewOuterConeAngle) {}
}
