#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A spot light component emits a directional cone shaped light (Eg a Torch).</summary>
[CppInclude("Components/SpotLightComponent.h")]
public partial class USpotLightComponent : UPointLightComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Degrees.</summary>
	public float InnerConeAngle;
	///<summary>Degrees.</summary>
	public float OuterConeAngle;
	///<summary>SetInnerConeAngle</summary>
	public  void SetInnerConeAngle(float NewInnerConeAngle) {}
	///<summary>SetOuterConeAngle</summary>
	public  void SetOuterConeAngle(float NewOuterConeAngle) {}
}
