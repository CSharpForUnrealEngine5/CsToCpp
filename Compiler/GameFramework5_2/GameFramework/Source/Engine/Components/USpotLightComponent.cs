#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/SpotLightComponent.h")]
///<summary>A spot light component emits a directional cone shaped light (Eg a Torch).</summary>
public partial class USpotLightComponent : UPointLightComponent {
// SpotLightComponent
	public float InnerConeAngle;
	public float OuterConeAngle;
	public  void SetInnerConeAngle(float NewInnerConeAngle) {}
	public  void SetOuterConeAngle(float NewOuterConeAngle) {}
}
