#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Sprite Asset</summary>
[CppInclude("PaperSprite.h")]
public partial class UPaperSprite : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Origin within SourceImage, prior to atlasing</summary>
	public FVector2D OriginInSourceImageBeforeTrimming;
	///<summary>Dimensions of SourceImage</summary>
	public FVector2D SourceImageDimensionBeforeTrimming;
	///<summary>This texture is trimmed, consider the values above</summary>
	public bool bTrimmedInSourceImage;
	///<summary>This texture is rotated in the atlas</summary>
	public bool bRotatedInSourceImage;
	///<summary>Dimension of the texture when this sprite was created</summary>
	public FVector2D SourceTextureDimension;
	///<summary>Position within SourceTexture (in pixels)</summary>
	public FVector2D SourceUV;
	///<summary>Dimensions within SourceTexture (in pixels)</summary>
	public FVector2D SourceDimension;
	///<summary>The source texture that the sprite comes from</summary>
	public TSoftObjectPtr<UTexture2D> SourceTexture;
	///<summary>SourceTextureCacheNeverSerialized</summary>
	public UTexture2D SourceTextureCacheNeverSerialized;
	///<summary>Additional source textures for other slots</summary>
	public TArray<UTexture> AdditionalSourceTextures;
	///<summary>Position within BakedSourceTexture (in pixels)</summary>
	public FVector2D BakedSourceUV;
	///<summary>Dimensions within BakedSourceTexture (in pixels)</summary>
	public FVector2D BakedSourceDimension;
	///<summary>BakedSourceTexture</summary>
	public UTexture2D BakedSourceTexture;
	///<summary>The material to use on a sprite instance if not overridden (this is the default material when only one is being used, and is the translucent/masked material for Diced render geometry, slot 0)</summary>
	public UMaterialInterface DefaultMaterial;
	///<summary>The alternate material to use on a sprite instance if not overridden (this is only used for Diced render geometry, and will be the opaque material in that case, slot 1)</summary>
	public UMaterialInterface AlternateMaterial;
	///<summary>List of sockets on this sprite</summary>
	public TArray<FPaperSpriteSocket> Sockets;
	///<summary>Collision domain (no collision, 2D, or 3D)</summary>
	public ESpriteCollisionMode SpriteCollisionDomain;
	///<summary>The scaling factor between pixels and Unreal units (cm) (e.g., 0.64 would make a 64 pixel wide sprite take up 100 cm)</summary>
	public float PixelsPerUnrealUnit;
	///<summary>Baked physics data.</summary>
	public UBodySetup BodySetup;
	///<summary>Pivot mode</summary>
	public ESpritePivotMode PivotMode;
	///<summary>Custom pivot point (relative to the sprite rectangle)</summary>
	public FVector2D CustomPivotPoint;
	///<summary>Should the pivot be snapped to a pixel boundary?</summary>
	public bool bSnapPivotToPixelGrid;
	///<summary>Custom collision geometry polygons (in texture space)</summary>
	public FSpriteGeometryCollection CollisionGeometry;
	///<summary>The extrusion thickness of collision geometry when using a 3D collision domain</summary>
	public float CollisionThickness;
	///<summary>Custom render geometry polygons (in texture space)</summary>
	public FSpriteGeometryCollection RenderGeometry;
	///<summary>Spritesheet group that this sprite belongs to</summary>
	public UPaperSpriteAtlas AtlasGroup;
	///<summary>The point at which the alternate material takes over in the baked render data (or INDEX_NONE)</summary>
	public int AlternateMaterialSplitIndex;
	///<summary>Baked render data (triangle vertices, stored as XY UV tuples)</summary>
	public TArray<FVector4> BakedRenderData;
}
