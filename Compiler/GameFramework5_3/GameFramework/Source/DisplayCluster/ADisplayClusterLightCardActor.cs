namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DisplayClusterLightCardActor.h")]
public partial class ADisplayClusterLightCardActor : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>Radius of light card polar coordinates. Does not include the effect of RadialOffset</summary>
	public double DistanceFromCenter;
	///<summary>Related to the Azimuth of light card polar coordinates</summary>
	public double Longitude;
	///<summary>Related to the Elevation of light card polar coordinates</summary>
	public double Latitude;
	///<summary>The UV coordinates of the light card, if it is in UV space</summary>
	public FVector2D UVCoordinates;
	///<summary>Roll rotation of light card around its plane axis</summary>
	public double Spin;
	///<summary>Pitch</summary>
	public double Pitch;
	///<summary>Yaw</summary>
	public double Yaw;
	///<summary>Scale</summary>
	public FVector2D Scale;
	///<summary>Used by the flush constraint to offset the location of the light card form the wall</summary>
	public double RadialOffset;
	///<summary>Indicates whether the light card is always made to be flush to a stage wall or not</summary>
	public bool bAlwaysFlushToWall;
	///<summary>Mask</summary>
	public EDisplayClusterLightCardMask Mask;
	///<summary>Texture</summary>
	public UTexture Texture;
	///<summary>Light card color, before any modifier is applied</summary>
	public FLinearColor Color;
	///<summary>Temperature</summary>
	public float Temperature;
	///<summary>Tint</summary>
	public float Tint;
	///<summary>2^Exposure color value multiplier</summary>
	public float Exposure;
	///<summary>Linear color value multiplier</summary>
	public float Gain;
	///<summary>Linear alpha multiplier</summary>
	public float Opacity;
	///<summary>Feathers in the alpha from the edges</summary>
	public float Feathering;
	///<summary>Settings related to an alpha gradient effect</summary>
	public FLightCardAlphaGradientSettings AlphaGradient;
	///<summary>A flag that controls whether the light card&#39;s location and rotation are locked to its &quot;owning&quot; root actor</summary>
	public bool bLockToOwningRootActor;
	///<summary>Indicates if the light card exists in 3D space or in UV space</summary>
	public bool bIsUVLightCard;
	///<summary>Polygon points when using this type of mask</summary>
	public TArray<FVector2D> Polygon;
	///<summary>Used to flag this light card as a proxy of a &quot;real&quot; light card. Used by the LightCard Editor</summary>
	public UTexture PolygonMask;
	///<summary>DefaultSceneRootComponent</summary>
	public USceneComponent DefaultSceneRootComponent;
	///<summary>MainSpringArmComponent</summary>
	public USpringArmComponent MainSpringArmComponent;
	///<summary>LightCardTransformerComponent</summary>
	public USceneComponent LightCardTransformerComponent;
	///<summary>LightCardComponent</summary>
	public UStaticMeshComponent LightCardComponent;
	///<summary>Components added by the IDisplayLightCardActorExtender</summary>
	public TMap<FName,UActorComponent> ExtenderNameToComponentMap;
	///<summary>LabelComponent</summary>
	public UDisplayClusterLabelComponent LabelComponent;
	///<summary>Manages stage actor properties</summary>
	public UDisplayClusterStageActorComponent StageActorComponent;
	///<summary>UVIndicatorComponent</summary>
	public UStaticMeshComponent UVIndicatorComponent;
	///<summary>Indicates this light card should be considered a flag</summary>
	public bool bIsLightCardFlag;
}
