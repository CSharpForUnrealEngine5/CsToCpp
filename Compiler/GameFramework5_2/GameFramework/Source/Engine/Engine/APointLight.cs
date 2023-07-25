#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/PointLight.h")]
public partial class APointLight : ALight {
// PointLight
	public UPointLightComponent PointLightComponent;
	public void SetRadius(float NewRadius) {}
	public void SetLightFalloffExponent(float NewLightFalloffExponent) {}
}
