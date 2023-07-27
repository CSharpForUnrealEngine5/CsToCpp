#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DMXFixtureActor.h")]
public partial class ADMXFixtureActor : ADMXFixtureActorBase {
// DMXFixtureActor
	public byte QualityLevel;
	public float BeamQuality;
	public float ZoomQuality;
	public USceneComponent Base;
	public USceneComponent Yoke;
	public USceneComponent Head;
	public  void InitializeFixture(UStaticMeshComponent StaticMeshLens,UStaticMeshComponent StaticMeshBeam) {}
	public  void SetLightIntensityMax(float NewLightIntensityMax) {}
	public  void SetLightDistanceMax(float NewLightDistanceMax) {}
	public  void SetLightColorTemp(float NewLightColorTemp) {}
	public  void SetSpotlightIntensityScale(float NewSpotlightIntensityScale) {}
	public  void SetPointlightIntensityScale(float NewPointlightIntensityScale) {}
	public  void SetLightCastShadow(bool bLightShouldCastShadow) {}
	public float LightIntensityMax;
	public float LightDistanceMax;
	public float LightColorTemp;
	public float SpotlightIntensityScale;
	public float PointlightIntensityScale;
	public bool LightCastShadow;
	public bool UseDynamicOcclusion;
	public bool DisableLights;
	public TArray<UStaticMeshComponent> StaticMeshComponents;
	public USpotLightComponent SpotLight;
	public UPointLightComponent PointLight;
	public UArrowComponent OcclusionDirection;
	public UMaterialInstance LensMaterialInstance;
	public UMaterialInstance BeamMaterialInstance;
	public UMaterialInstance SpotLightMaterialInstance;
	public UMaterialInstance PointLightMaterialInstance;
	public UMaterialInstanceDynamic DynamicMaterialLens;
	public UMaterialInstanceDynamic DynamicMaterialBeam;
	public UMaterialInstanceDynamic DynamicMaterialSpotLight;
	public UMaterialInstanceDynamic DynamicMaterialPointLight;
	public float MinQuality;
	public float MaxQuality;
}
