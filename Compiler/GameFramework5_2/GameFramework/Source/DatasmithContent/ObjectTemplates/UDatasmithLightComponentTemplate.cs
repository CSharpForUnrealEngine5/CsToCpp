#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ObjectTemplates/DatasmithLightComponentTemplate.h")]
public partial class UDatasmithLightComponentTemplate : UDatasmithObjectTemplate {
// DatasmithLightComponentTemplate
	public bool bVisible;
	public bool CastShadows;
	public bool bUseTemperature;
	public bool bUseIESBrightness;
	public float Intensity;
	public float Temperature;
	public float IESBrightnessScale;
	public FLinearColor LightColor;
	public UMaterialInterface LightFunctionMaterial;
	public UTextureLightProfile IESTexture;
}
