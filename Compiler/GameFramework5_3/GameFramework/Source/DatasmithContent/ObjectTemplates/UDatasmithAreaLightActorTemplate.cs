namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ObjectTemplates/DatasmithAreaLightActorTemplate.h")]
public partial class UDatasmithAreaLightActorTemplate : UDatasmithObjectTemplate {
	public static UClass StaticClass() {return default;}
	///<summary>LightType</summary>
	public EDatasmithAreaLightActorType LightType;
	///<summary>LightShape</summary>
	public EDatasmithAreaLightActorShape LightShape;
	///<summary>Dimensions</summary>
	public FVector2D Dimensions;
	///<summary>Color</summary>
	public FLinearColor Color;
	///<summary>Intensity</summary>
	public float Intensity;
	///<summary>IntensityUnits</summary>
	public ELightUnits IntensityUnits;
	///<summary>Temperature</summary>
	public float Temperature;
	///<summary>IESTexture</summary>
	public TSoftObjectPtr<UTextureLightProfile> IESTexture;
	///<summary>bUseIESBrightness</summary>
	public bool bUseIESBrightness;
	///<summary>IESBrightnessScale</summary>
	public float IESBrightnessScale;
	///<summary>Rotation</summary>
	public FRotator Rotation;
	///<summary>SourceRadius</summary>
	public float SourceRadius;
	///<summary>SourceLength</summary>
	public float SourceLength;
	///<summary>AttenuationRadius</summary>
	public float AttenuationRadius;
}
