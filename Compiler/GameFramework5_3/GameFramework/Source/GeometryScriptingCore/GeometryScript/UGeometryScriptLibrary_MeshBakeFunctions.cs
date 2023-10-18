namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshBakeFunctions.h")]
public partial class UGeometryScriptLibrary_MeshBakeFunctions : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>MakeBakeTypeTangentNormal</summary>
	public static FGeometryScriptBakeTypeOptions MakeBakeTypeTangentNormal() { return default; }
	///<summary>MakeBakeTypeObjectNormal</summary>
	public static FGeometryScriptBakeTypeOptions MakeBakeTypeObjectNormal() { return default; }
	///<summary>MakeBakeTypeFaceNormal</summary>
	public static FGeometryScriptBakeTypeOptions MakeBakeTypeFaceNormal() { return default; }
	///<summary>MakeBakeTypeBentNormal</summary>
	public static FGeometryScriptBakeTypeOptions MakeBakeTypeBentNormal(int OcclusionRays/*=16*/,float MaxDistance/*=0.0f*/,float SpreadAngle/*=180.0f*/) { return default; }
	///<summary>MakeBakeTypePosition</summary>
	public static FGeometryScriptBakeTypeOptions MakeBakeTypePosition() { return default; }
	///<summary>MakeBakeTypeCurvature</summary>
	public static FGeometryScriptBakeTypeOptions MakeBakeTypeCurvature(EGeometryScriptBakeCurvatureTypeMode CurvatureType/*=EGeometryScriptBakeCurvatureTypeMode.Mean*/,EGeometryScriptBakeCurvatureColorMode ColorMapping/*=EGeometryScriptBakeCurvatureColorMode.Grayscale*/,float ColorRangeMultiplier/*=1.0f*/,float MinRangeMultiplier/*=0.0f*/,EGeometryScriptBakeCurvatureClampMode Clamping/*=EGeometryScriptBakeCurvatureClampMode.None*/) { return default; }
	///<summary>MakeBakeTypeAmbientOcclusion</summary>
	public static FGeometryScriptBakeTypeOptions MakeBakeTypeAmbientOcclusion(int OcclusionRays/*=16*/,float MaxDistance/*=0.0f*/,float SpreadAngle/*=180.0f*/,float BiasAngle/*=15.0f*/) { return default; }
	///<summary>MakeBakeTypeTexture</summary>
	public static FGeometryScriptBakeTypeOptions MakeBakeTypeTexture(UTexture2D SourceTexture/*=nullptr*/,int SourceUVLayer/*=0*/) { return default; }
	///<summary>MakeBakeTypeMultiTexture</summary>
	public static FGeometryScriptBakeTypeOptions MakeBakeTypeMultiTexture(TArray<UTexture2D> MaterialIDSourceTextures,int SourceUVLayer/*=0*/) { return default; }
	///<summary>MakeBakeTypeVertexColor</summary>
	public static FGeometryScriptBakeTypeOptions MakeBakeTypeVertexColor() { return default; }
	///<summary>MakeBakeTypeMaterialID</summary>
	public static FGeometryScriptBakeTypeOptions MakeBakeTypeMaterialID() { return default; }
	///<summary>BakeTexture</summary>
	public static TArray<UTexture2D> BakeTexture(UDynamicMesh TargetMesh,FTransform TargetTransform,FGeometryScriptBakeTargetMeshOptions TargetOptions,UDynamicMesh SourceMesh,FTransform SourceTransform,FGeometryScriptBakeSourceMeshOptions SourceOptions,TArray<FGeometryScriptBakeTypeOptions> BakeTypes,FGeometryScriptBakeTextureOptions BakeOptions,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>BakeVertex</summary>
	public static UDynamicMesh BakeVertex(UDynamicMesh TargetMesh,FTransform TargetTransform,FGeometryScriptBakeTargetMeshOptions TargetOptions,UDynamicMesh SourceMesh,FTransform SourceTransform,FGeometryScriptBakeSourceMeshOptions SourceOptions,FGeometryScriptBakeOutputType BakeTypes,FGeometryScriptBakeVertexOptions BakeOptions,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>BakeTextureFromRenderCaptures</summary>
	public static FGeometryScriptRenderCaptureTextures BakeTextureFromRenderCaptures(UDynamicMesh TargetMesh,FTransform TargetLocalToWorld,FGeometryScriptBakeTargetMeshOptions TargetOptions,TArray<AActor> SourceActors,FGeometryScriptBakeRenderCaptureOptions BakeOptions,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
}
