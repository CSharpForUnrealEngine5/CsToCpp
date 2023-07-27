#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PaperSprite.h")]
///<summary>Sprite Asset</summary>
public partial class UPaperSprite : UObject {
// PaperSprite
	public FVector2D OriginInSourceImageBeforeTrimming;
	public FVector2D SourceImageDimensionBeforeTrimming;
	public bool bTrimmedInSourceImage;
	public bool bRotatedInSourceImage;
	public FVector2D SourceTextureDimension;
	public FVector2D SourceUV;
	public FVector2D SourceDimension;
	public TSoftObjectPtr<UTexture2D> SourceTexture;
	public UTexture2D SourceTextureCacheNeverSerialized;
	public TArray<UTexture> AdditionalSourceTextures;
	public FVector2D BakedSourceUV;
	public FVector2D BakedSourceDimension;
	public UTexture2D BakedSourceTexture;
	public UMaterialInterface DefaultMaterial;
	public UMaterialInterface AlternateMaterial;
	public TArray<FPaperSpriteSocket> Sockets;
	public ESpriteCollisionMode SpriteCollisionDomain;
	public float PixelsPerUnrealUnit;
	public UBodySetup BodySetup;
	public ESpritePivotMode PivotMode;
	public FVector2D CustomPivotPoint;
	public bool bSnapPivotToPixelGrid;
	public FSpriteGeometryCollection CollisionGeometry;
	public float CollisionThickness;
	public FSpriteGeometryCollection RenderGeometry;
	public UPaperSpriteAtlas AtlasGroup;
	public int AlternateMaterialSplitIndex;
	public TArray<FVector4> BakedRenderData;
}
