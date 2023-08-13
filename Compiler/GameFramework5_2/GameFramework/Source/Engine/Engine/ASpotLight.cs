namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/SpotLight.h")]
public partial class ASpotLight : ALight {
	public static UClass StaticClass() {return default;}
	///<summary>SpotLightComponent</summary>
	public USpotLightComponent SpotLightComponent;
	///<summary>ArrowComponent</summary>
	public UArrowComponent ArrowComponent;
	///<summary>BEGIN DEPRECATED (use component functions now in level script)</summary>
	public void SetInnerConeAngle(float NewInnerConeAngle) {}
	///<summary>SetOuterConeAngle</summary>
	public void SetOuterConeAngle(float NewOuterConeAngle) {}
}
