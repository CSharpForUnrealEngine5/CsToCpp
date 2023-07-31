#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ObjectTemplates/DatasmithLightComponentTemplate.h")]
public partial class UDatasmithLightComponentTemplate : UDatasmithObjectTemplate {
	///<summary>bVisible</summary>
	public bool bVisible;
	///<summary>CastShadows</summary>
	public bool CastShadows;
	///<summary>bUseTemperature</summary>
	public bool bUseTemperature;
	///<summary>bUseIESBrightness</summary>
	public bool bUseIESBrightness;
	///<summary>Intensity</summary>
	public float Intensity;
	///<summary>Temperature</summary>
	public float Temperature;
	///<summary>IESBrightnessScale</summary>
	public float IESBrightnessScale;
	///<summary>LightColor</summary>
	public FLinearColor LightColor;
	///<summary>LightFunctionMaterial</summary>
	public UMaterialInterface LightFunctionMaterial;
	///<summary>IESTexture</summary>
	public UTextureLightProfile IESTexture;
}
