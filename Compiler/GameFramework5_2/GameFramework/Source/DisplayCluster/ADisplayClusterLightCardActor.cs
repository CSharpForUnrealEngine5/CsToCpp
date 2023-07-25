#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DisplayClusterLightCardActor.h")]
public partial class ADisplayClusterLightCardActor : AActor {
// DisplayClusterLightCardActor
	public double DistanceFromCenter;
	public double Longitude;
	public double Latitude;
	public FVector2D UVCoordinates;
	public double Spin;
	public double Pitch;
	public double Yaw;
	public FVector2D Scale;
	public double RadialOffset;
	public bool bAlwaysFlushToWall;
	public EDisplayClusterLightCardMask Mask;
	public UTexture Texture;
	public FLinearColor Color;
	public float Temperature;
	public float Tint;
	public float Exposure;
	public float Gain;
	public float Opacity;
	public float Feathering;
	public FLightCardAlphaGradientSettings AlphaGradient;
	public bool bLockToOwningRootActor;
	public bool bIsUVLightCard;
	public TArray<FVector2D> Polygon;
	public UTexture PolygonMask;
	public USceneComponent DefaultSceneRootComponent;
	public USpringArmComponent MainSpringArmComponent;
	public USceneComponent LightCardTransformerComponent;
	public UStaticMeshComponent LightCardComponent;
	public TMap<string,UActorComponent> ExtenderNameToComponentMap;
	public UDisplayClusterLabelComponent LabelComponent;
	public UDisplayClusterStageActorComponent StageActorComponent;
	public UStaticMeshComponent UVIndicatorComponent;
	public bool bIsLightCardFlag;
}
