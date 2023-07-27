#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshBakeFunctions.h")]
public partial class UGeometryScriptLibrary_MeshBakeFunctions : UBlueprintFunctionLibrary {
// GeometryScriptLibrary_MeshBakeFunctions
	public static FGeometryScriptBakeTypeOptions MakeBakeTypeTangentNormal() { return default; }
	public static FGeometryScriptBakeTypeOptions MakeBakeTypeObjectNormal() { return default; }
	public static FGeometryScriptBakeTypeOptions MakeBakeTypeFaceNormal() { return default; }
	public static FGeometryScriptBakeTypeOptions MakeBakeTypeBentNormal(int OcclusionRays/*=16*/,float MaxDistance/*=0.0f*/,float SpreadAngle/*=180.0f*/) { return default; }
	public static FGeometryScriptBakeTypeOptions MakeBakeTypePosition() { return default; }
	public static FGeometryScriptBakeTypeOptions MakeBakeTypeCurvature(EGeometryScriptBakeCurvatureTypeMode CurvatureType/*=EGeometryScriptBakeCurvatureTypeMode.Mean*/,EGeometryScriptBakeCurvatureColorMode ColorMapping/*=EGeometryScriptBakeCurvatureColorMode.Grayscale*/,float ColorRangeMultiplier/*=1.0f*/,float MinRangeMultiplier/*=0.0f*/,EGeometryScriptBakeCurvatureClampMode Clamping/*=EGeometryScriptBakeCurvatureClampMode.None*/) { return default; }
	public static FGeometryScriptBakeTypeOptions MakeBakeTypeAmbientOcclusion(int OcclusionRays/*=16*/,float MaxDistance/*=0.0f*/,float SpreadAngle/*=180.0f*/,float BiasAngle/*=15.0f*/) { return default; }
	public static FGeometryScriptBakeTypeOptions MakeBakeTypeTexture(UTexture2D SourceTexture/*=nullptr*/,int SourceUVLayer/*=0*/) { return default; }
	public static FGeometryScriptBakeTypeOptions MakeBakeTypeMultiTexture(TArray<UTexture2D> MaterialIDSourceTextures,int SourceUVLayer/*=0*/) { return default; }
	public static FGeometryScriptBakeTypeOptions MakeBakeTypeVertexColor() { return default; }
	public static FGeometryScriptBakeTypeOptions MakeBakeTypeMaterialID() { return default; }
	public static TArray<UTexture2D> BakeTexture(UDynamicMesh TargetMesh,FTransform TargetTransform,FGeometryScriptBakeTargetMeshOptions TargetOptions,UDynamicMesh SourceMesh,FTransform SourceTransform,FGeometryScriptBakeSourceMeshOptions SourceOptions,TArray<FGeometryScriptBakeTypeOptions> BakeTypes,FGeometryScriptBakeTextureOptions BakeOptions,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh BakeVertex(UDynamicMesh TargetMesh,FTransform TargetTransform,FGeometryScriptBakeTargetMeshOptions TargetOptions,UDynamicMesh SourceMesh,FTransform SourceTransform,FGeometryScriptBakeSourceMeshOptions SourceOptions,FGeometryScriptBakeOutputType BakeTypes,FGeometryScriptBakeVertexOptions BakeOptions,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static FGeometryScriptRenderCaptureTextures BakeTextureFromRenderCaptures(UDynamicMesh TargetMesh,FTransform TargetLocalToWorld,FGeometryScriptBakeTargetMeshOptions TargetOptions,TArray<AActor> SourceActors,FGeometryScriptBakeRenderCaptureOptions BakeOptions,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
}
