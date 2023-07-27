#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DatasmithAreaLightActor.h")]
public partial class ADatasmithAreaLightActor : AActor {
// DatasmithAreaLightActor
	public EComponentMobility Mobility;
	public EDatasmithAreaLightActorType LightType;
	public EDatasmithAreaLightActorShape LightShape;
	public FVector2D Dimensions;
	public float Intensity;
	public ELightUnits IntensityUnits;
	public FLinearColor Color;
	public float Temperature;
	public UTextureLightProfile IESTexture;
	public bool bUseIESBrightness;
	public float IESBrightnessScale;
	public FRotator Rotation;
	public float SourceRadius;
	public float SourceLength;
	public float AttenuationRadius;
	public float SpotlightInnerAngle;
	public float SpotlightOuterAngle;
}
