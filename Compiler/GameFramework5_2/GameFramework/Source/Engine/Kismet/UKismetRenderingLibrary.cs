#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Kismet/KismetRenderingLibrary.h")]
public partial class UKismetRenderingLibrary : UBlueprintFunctionLibrary {
// KismetRenderingLibrary
	public static void ClearRenderTarget2D(UObject WorldContextObject,UTextureRenderTarget2D TextureRenderTarget,FLinearColor ClearColor/*=new FLinearColor(0,0,0,1)*/) {}
	public static UTextureRenderTarget2D CreateRenderTarget2D(UObject WorldContextObject,int Width/*=256*/,int Height/*=256*/,ETextureRenderTargetFormat Format/*=RTF_RGBA16f*/,FLinearColor ClearColor/*=FLinearColor.Black*/,bool bAutoGenerateMipMaps/*=false*/,bool bSupportUAVs/*=false*/) { return default; }
	public static UTextureRenderTarget2DArray CreateRenderTarget2DArray(UObject WorldContextObject,int Width/*=256*/,int Height/*=256*/,int Slices/*=1*/,ETextureRenderTargetFormat Format/*=RTF_RGBA16f*/,FLinearColor ClearColor/*=FLinearColor.Black*/,bool bAutoGenerateMipMaps/*=false*/,bool bSupportUAVs/*=false*/) { return default; }
	public static UTextureRenderTargetVolume CreateRenderTargetVolume(UObject WorldContextObject,int Width/*=16*/,int Height/*=16*/,int Depth/*=16*/,ETextureRenderTargetFormat Format/*=RTF_RGBA16f*/,FLinearColor ClearColor/*=FLinearColor.Black*/,bool bAutoGenerateMipMaps/*=false*/,bool bSupportUAVs/*=false*/) { return default; }
	public static void ReleaseRenderTarget2D(UTextureRenderTarget2D TextureRenderTarget) {}
	public static void ResizeRenderTarget2D(UTextureRenderTarget2D TextureRenderTarget,int Width/*=256*/,int Height/*=256*/) {}
	public static void DrawMaterialToRenderTarget(UObject WorldContextObject,UTextureRenderTarget2D TextureRenderTarget,UMaterialInterface Material) {}
	public static UTexture2D RenderTargetCreateStaticTexture2DEditorOnly(UTextureRenderTarget2D RenderTarget,string Name/*="Texture"*/,TextureCompressionSettings CompressionSettings/*=TC_Default*/,TextureMipGenSettings MipSettings/*=TMGS_FromTextureGroup*/) { return default; }
	public static void ConvertRenderTargetToTexture2DEditorOnly(UObject WorldContextObject,UTextureRenderTarget2D RenderTarget,UTexture2D Texture) {}
	public static void ExportRenderTarget(UObject WorldContextObject,UTextureRenderTarget2D TextureRenderTarget,string FilePath,string FileName) {}
	public static FColor ReadRenderTargetPixel(UObject WorldContextObject,UTextureRenderTarget2D TextureRenderTarget,int X,int Y) { return default; }
	public static FColor ReadRenderTargetUV(UObject WorldContextObject,UTextureRenderTarget2D TextureRenderTarget,float U,float V) { return default; }
	public static bool ReadRenderTarget(UObject WorldContextObject,UTextureRenderTarget2D TextureRenderTarget,TArray<FColor> OutSamples,bool bNormalize/*=true*/) { return default; }
	public static FLinearColor ReadRenderTargetRawPixel(UObject WorldContextObject,UTextureRenderTarget2D TextureRenderTarget,int X,int Y,bool bNormalize/*=true*/) { return default; }
	public static TArray<FLinearColor> ReadRenderTargetRawPixelArea(UObject WorldContextObject,UTextureRenderTarget2D TextureRenderTarget,int MinX,int MinY,int MaxX,int MaxY,bool bNormalize/*=true*/) { return default; }
	public static FLinearColor ReadRenderTargetRawUV(UObject WorldContextObject,UTextureRenderTarget2D TextureRenderTarget,float U,float V,bool bNormalize/*=true*/) { return default; }
	public static bool ReadRenderTargetRaw(UObject WorldContextObject,UTextureRenderTarget2D TextureRenderTarget,TArray<FLinearColor> OutLinearSamples,bool bNormalize/*=true*/) { return default; }
	public static TArray<FLinearColor> ReadRenderTargetRawUVArea(UObject WorldContextObject,UTextureRenderTarget2D TextureRenderTarget,FBox2D Area,bool bNormalize/*=true*/) { return default; }
	public static void ExportTexture2D(UObject WorldContextObject,UTexture2D Texture,string FilePath,string FileName) {}
	public static UTexture2D ImportFileAsTexture2D(UObject WorldContextObject,string Filename) { return default; }
	public static UTexture2D ImportBufferAsTexture2D(UObject WorldContextObject,TArray<byte> Buffer) { return default; }
	public static void BeginDrawCanvasToRenderTarget(UObject WorldContextObject,UTextureRenderTarget2D TextureRenderTarget,UCanvas Canvas,FVector2D Size,FDrawToRenderTargetContext Context) {}
	public static void EndDrawCanvasToRenderTarget(UObject WorldContextObject,FDrawToRenderTargetContext Context) {}
	public static FSkelMeshSkinWeightInfo MakeSkinWeightInfo(int Bone0,byte Weight0,int Bone1,byte Weight1,int Bone2,byte Weight2,int Bone3,byte Weight3) { return default; }
	public static void BreakSkinWeightInfo(FSkelMeshSkinWeightInfo InWeight,int Bone0,byte Weight0,int Bone1,byte Weight1,int Bone2,byte Weight2,int Bone3,byte Weight3) {}
	public static void SetCastInsetShadowForAllAttachments(UPrimitiveComponent PrimitiveComponent,bool bCastInsetShadow,bool bLightAttachmentsAsGroup) {}
	public static FMatrix CalculateProjectionMatrix(FMinimalViewInfo MinimalViewInfo) { return default; }
	public static void EnablePathTracing(bool bEnablePathTracer) {}
}
