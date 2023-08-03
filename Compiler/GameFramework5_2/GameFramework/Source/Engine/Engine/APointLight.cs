#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/PointLight.h")]
public partial class APointLight : ALight {
	public static UClass StaticClass() {return default;}
	///<summary>PointLightComponent</summary>
	public UPointLightComponent PointLightComponent;
	///<summary>BEGIN DEPRECATED (use component functions now in level script)</summary>
	public  void SetRadius(float NewRadius) {}
	///<summary>SetLightFalloffExponent</summary>
	public  void SetLightFalloffExponent(float NewLightFalloffExponent) {}
}
