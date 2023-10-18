namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DatasmithAreaLightActor.h")]
public partial class ADatasmithAreaLightActor : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>Mobility</summary>
	public EComponentMobility Mobility;
	///<summary>LightType</summary>
	public EDatasmithAreaLightActorType LightType;
	///<summary>LightShape</summary>
	public EDatasmithAreaLightActorShape LightShape;
	///<summary>Dimensions</summary>
	public FVector2D Dimensions;
	///<summary>Intensity</summary>
	public float Intensity;
	///<summary>IntensityUnits</summary>
	public ELightUnits IntensityUnits;
	///<summary>Color</summary>
	public FLinearColor Color;
	///<summary>Temperature</summary>
	public float Temperature;
	///<summary>IESTexture</summary>
	public UTextureLightProfile IESTexture;
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
	///<summary>SpotlightInnerAngle</summary>
	public float SpotlightInnerAngle;
	///<summary>SpotlightOuterAngle</summary>
	public float SpotlightOuterAngle;
}
