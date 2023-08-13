namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Kismet/KismetRenderingLibrary.h")]
public partial class UKismetRenderingLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Clears the specified render target with the given ClearColor.</summary>
	public static void ClearRenderTarget2D(UObject WorldContextObject,UTextureRenderTarget2D TextureRenderTarget,FLinearColor ClearColor/*=new FLinearColor(0,0,0,1)*/) {}
	///<summary>Creates a new render target and initializes it to the specified dimensions</summary>
	public static UTextureRenderTarget2D CreateRenderTarget2D(UObject WorldContextObject,int Width/*=256*/,int Height/*=256*/,ETextureRenderTargetFormat Format/*=RTF_RGBA16f*/,FLinearColor ClearColor/*=FLinearColor.Black*/,bool bAutoGenerateMipMaps/*=false*/,bool bSupportUAVs/*=false*/) { return default; }
	///<summary>Creates a new render target array and initializes it to the specified dimensions</summary>
	public static UTextureRenderTarget2DArray CreateRenderTarget2DArray(UObject WorldContextObject,int Width/*=256*/,int Height/*=256*/,int Slices/*=1*/,ETextureRenderTargetFormat Format/*=RTF_RGBA16f*/,FLinearColor ClearColor/*=FLinearColor.Black*/,bool bAutoGenerateMipMaps/*=false*/,bool bSupportUAVs/*=false*/) { return default; }
	///<summary>Creates a new volume render target and initializes it to the specified dimensions</summary>
	public static UTextureRenderTargetVolume CreateRenderTargetVolume(UObject WorldContextObject,int Width/*=16*/,int Height/*=16*/,int Depth/*=16*/,ETextureRenderTargetFormat Format/*=RTF_RGBA16f*/,FLinearColor ClearColor/*=FLinearColor.Black*/,bool bAutoGenerateMipMaps/*=false*/,bool bSupportUAVs/*=false*/) { return default; }
	///<summary>Manually releases GPU resources of a render target. This is useful for blueprint creating a lot of render target that would</summary>
	public static void ReleaseRenderTarget2D(UTextureRenderTarget2D TextureRenderTarget) {}
	///<summary>Changes the resolution of a render target. This is useful for when you need to resize the game viewport or change the in-game resolution during runtime</summary>
	public static void ResizeRenderTarget2D(UTextureRenderTarget2D TextureRenderTarget,int Width/*=256*/,int Height/*=256*/) {}
	///<summary>Renders a quad with the material applied to the specified render target.</summary>
	public static void DrawMaterialToRenderTarget(UObject WorldContextObject,UTextureRenderTarget2D TextureRenderTarget,UMaterialInterface Material) {}
	///<summary>Creates a new Static Texture from a Render Target 2D.</summary>
	public static UTexture2D RenderTargetCreateStaticTexture2DEditorOnly(UTextureRenderTarget2D RenderTarget,string Name/*="Texture"*/,TextureCompressionSettings CompressionSettings/*=TC_Default*/,TextureMipGenSettings MipSettings/*=TMGS_FromTextureGroup*/) { return default; }
	///<summary>Copies the contents of a render target to a UTexture2D</summary>
	public static void ConvertRenderTargetToTexture2DEditorOnly(UObject WorldContextObject,UTextureRenderTarget2D RenderTarget,UTexture2D Texture) {}
	///<summary>Exports a render target as a HDR or PNG image onto the disk (depending on the format of the render target)</summary>
	public static void ExportRenderTarget(UObject WorldContextObject,UTextureRenderTarget2D TextureRenderTarget,string FilePath,string FileName) {}
	///<summary>Incredibly inefficient and slow operation! Read a value as sRGB color from a render target using integer pixel coordinates.</summary>
	public static FColor ReadRenderTargetPixel(UObject WorldContextObject,UTextureRenderTarget2D TextureRenderTarget,int X,int Y) { return default; }
	///<summary>Incredibly inefficient and slow operation! Read a value as sRGB color from a render target using UV [0,1]x[0,1] coordinates.</summary>
	public static FColor ReadRenderTargetUV(UObject WorldContextObject,UTextureRenderTarget2D TextureRenderTarget,float U,float V) { return default; }
	///<summary>Incredibly inefficient and slow operation! Reads entire render target as sRGB color and returns a linear array of sRGB colors.</summary>
	public static bool ReadRenderTarget(UObject WorldContextObject,UTextureRenderTarget2D TextureRenderTarget,TArray<FColor> OutSamples,bool bNormalize/*=true*/) { return default; }
	///<summary>Incredibly inefficient and slow operation! Read a value as-is from a render target using integer pixel coordinates.</summary>
	public static FLinearColor ReadRenderTargetRawPixel(UObject WorldContextObject,UTextureRenderTarget2D TextureRenderTarget,int X,int Y,bool bNormalize/*=true*/) { return default; }
	///<summary>Incredibly inefficient and slow operation! Read an area of values as-is from a render target using a rectangle defined by integer pixel coordinates.</summary>
	public static TArray<FLinearColor> ReadRenderTargetRawPixelArea(UObject WorldContextObject,UTextureRenderTarget2D TextureRenderTarget,int MinX,int MinY,int MaxX,int MaxY,bool bNormalize/*=true*/) { return default; }
	///<summary>Incredibly inefficient and slow operation! Read a value as-is from a render target using UV [0,1]x[0,1] coordinates.</summary>
	public static FLinearColor ReadRenderTargetRawUV(UObject WorldContextObject,UTextureRenderTarget2D TextureRenderTarget,float U,float V,bool bNormalize/*=true*/) { return default; }
	///<summary>Incredibly inefficient and slow operation! Read entire texture as-is from a render target.</summary>
	public static bool ReadRenderTargetRaw(UObject WorldContextObject,UTextureRenderTarget2D TextureRenderTarget,TArray<FLinearColor> OutLinearSamples,bool bNormalize/*=true*/) { return default; }
	///<summary>Incredibly inefficient and slow operation! Read an area of values as-is from a render target using a rectangle defined by UV [0,1]x[0,1] coordinates.</summary>
	public static TArray<FLinearColor> ReadRenderTargetRawUVArea(UObject WorldContextObject,UTextureRenderTarget2D TextureRenderTarget,FBox2D Area,bool bNormalize/*=true*/) { return default; }
	///<summary>Exports a Texture2D as a HDR image onto the disk.</summary>
	public static void ExportTexture2D(UObject WorldContextObject,UTexture2D Texture,string FilePath,string FileName) {}
	///<summary>Imports a texture file from disk and creates Texture2D from it.</summary>
	public static UTexture2D ImportFileAsTexture2D(UObject WorldContextObject,string Filename) { return default; }
	///<summary>Imports a texture from a buffer and creates Texture2D from it.</summary>
	public static UTexture2D ImportBufferAsTexture2D(UObject WorldContextObject,TArray<byte> Buffer) { return default; }
	///<summary>Returns a Canvas object that can be used to draw to the specified render target.</summary>
	public static void BeginDrawCanvasToRenderTarget(UObject WorldContextObject,UTextureRenderTarget2D TextureRenderTarget,UCanvas Canvas,FVector2D Size,FDrawToRenderTargetContext Context) {}
	///<summary>Must be paired with a BeginDrawCanvasToRenderTarget to complete rendering to a render target.</summary>
	public static void EndDrawCanvasToRenderTarget(UObject WorldContextObject,FDrawToRenderTargetContext Context) {}
	///<summary>Create FSkelMeshSkinWeightInfo</summary>
	public static FSkelMeshSkinWeightInfo MakeSkinWeightInfo(int Bone0,byte Weight0,int Bone1,byte Weight1,int Bone2,byte Weight2,int Bone3,byte Weight3) { return default; }
	///<summary>Break FSkelMeshSkinWeightInfo</summary>
	public static void BreakSkinWeightInfo(FSkelMeshSkinWeightInfo InWeight,int Bone0,byte Weight0,int Bone1,byte Weight1,int Bone2,byte Weight2,int Bone3,byte Weight3) {}
	///<summary>Set the inset shadow casting state of the given component and all its child attachments.</summary>
	public static void SetCastInsetShadowForAllAttachments(UPrimitiveComponent PrimitiveComponent,bool bCastInsetShadow,bool bLightAttachmentsAsGroup) {}
	///<summary>Calculates the projection matrix using this view info&#39;s aspect ratio (regardless of bConstrainAspectRatio)</summary>
	public static FMatrix CalculateProjectionMatrix(FMinimalViewInfo MinimalViewInfo) { return default; }
	///<summary>Enables or disables the path tracer for all viewports simulatenously.</summary>
	public static void EnablePathTracing(bool bEnablePathTracer) {}
}
