namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DMXFixtureActor.h")]
public partial class ADMXFixtureActor : ADMXFixtureActorBase {
	public static UClass StaticClass() {return default;}
	///<summary>Visual quality level that changes the number of samples in the volumetric beam</summary>
	public EDMXFixtureQualityLevel QualityLevel;
	///<summary>Visual quality for the light beam - small value is visually better but cost more on GPU</summary>
	public float BeamQuality;
	///<summary>Visual quality for the light beam when zoom is wide - small value is visually better but cost more on GPU</summary>
	public float ZoomQuality;
	///<summary>HIERARCHY---------------------------------</summary>
	public USceneComponent Base;
	///<summary>Yoke</summary>
	public USceneComponent Yoke;
	///<summary>Head</summary>
	public USceneComponent Head;
	///<summary>FUNCTIONS---------------------------------</summary>
	public void InitializeFixture(UStaticMeshComponent StaticMeshLens,UStaticMeshComponent StaticMeshBeam) {}
	///<summary>Sets the a new max light intensity</summary>
	public void SetLightIntensityMax(float NewLightIntensityMax) {}
	///<summary>Sets a new max light distance</summary>
	public void SetLightDistanceMax(float NewLightDistanceMax) {}
	///<summary>Sets a new light color temperature</summary>
	public void SetLightColorTemp(float NewLightColorTemp) {}
	///<summary>Sets a new spotlight intensity scale</summary>
	public void SetSpotlightIntensityScale(float NewSpotlightIntensityScale) {}
	///<summary>Sets a new pointlight intensity scale</summary>
	public void SetPointlightIntensityScale(float NewPointlightIntensityScale) {}
	///<summary>Sets if the light should cast shadows</summary>
	public void SetLightCastShadow(bool bLightShouldCastShadow) {}
	///<summary>Light intensity at 1 steradian (32.77deg half angle)</summary>
	public float LightIntensityMax;
	///<summary>Sets Attenuation Radius on the spotlight and pointlight</summary>
	public float LightDistanceMax;
	///<summary>Light color temperature on the spotlight and pointlight</summary>
	public float LightColorTemp;
	///<summary>Scales spotlight intensity</summary>
	public float SpotlightIntensityScale;
	///<summary>Scales pointlight intensity</summary>
	public float PointlightIntensityScale;
	///<summary>Enable/disable cast shadow on the spotlight and pointlight</summary>
	public bool LightCastShadow;
	///<summary>Simple solution useful for walls, 1 linetrace from the center</summary>
	public bool UseDynamicOcclusion;
	///<summary>Disable lights rendering in the fixture to save on GPU</summary>
	public bool DisableLights;
	///<summary>COMPONENTS ---------------------------------</summary>
	public TArray<UStaticMeshComponent> StaticMeshComponents;
	///<summary>SpotLight</summary>
	public USpotLightComponent SpotLight;
	///<summary>PointLight</summary>
	public UPointLightComponent PointLight;
	///<summary>OcclusionDirection</summary>
	public UArrowComponent OcclusionDirection;
	///<summary>MATERIALS ---------------------------------</summary>
	public UMaterialInstance LensMaterialInstance;
	///<summary>BeamMaterialInstance</summary>
	public UMaterialInstance BeamMaterialInstance;
	///<summary>SpotLightMaterialInstance</summary>
	public UMaterialInstance SpotLightMaterialInstance;
	///<summary>PointLightMaterialInstance</summary>
	public UMaterialInstance PointLightMaterialInstance;
	///<summary>DynamicMaterialLens</summary>
	public UMaterialInstanceDynamic DynamicMaterialLens;
	///<summary>DynamicMaterialBeam</summary>
	public UMaterialInstanceDynamic DynamicMaterialBeam;
	///<summary>DynamicMaterialSpotLight</summary>
	public UMaterialInstanceDynamic DynamicMaterialSpotLight;
	///<summary>DynamicMaterialPointLight</summary>
	public UMaterialInstanceDynamic DynamicMaterialPointLight;
	///<summary>MinQuality</summary>
	public float MinQuality;
	///<summary>MaxQuality</summary>
	public float MaxQuality;
}
