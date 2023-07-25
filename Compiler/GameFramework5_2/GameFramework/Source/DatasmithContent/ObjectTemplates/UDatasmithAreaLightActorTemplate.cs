#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ObjectTemplates/DatasmithAreaLightActorTemplate.h")]
public partial class UDatasmithAreaLightActorTemplate : UDatasmithObjectTemplate {
// DatasmithAreaLightActorTemplate
	public EDatasmithAreaLightActorType LightType;
	public EDatasmithAreaLightActorShape LightShape;
	public FVector2D Dimensions;
	public FLinearColor Color;
	public float Intensity;
	public ELightUnits IntensityUnits;
	public float Temperature;
	public TSoftObjectPtr<UTextureLightProfile> IESTexture;
	public bool bUseIESBrightness;
	public float IESBrightnessScale;
	public FRotator Rotation;
	public float SourceRadius;
	public float SourceLength;
	public float AttenuationRadius;
}
