#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("USDConversionBlueprintContext.h")]
///<summary>Wraps the UnrealToUsd component conversion functions from the USDUtilities module so that they can be used by</summary>
public partial class UUsdConversionBlueprintContext : UObject {
// UsdConversionBlueprintContext
	public  void SetStageRootLayer(FFilePath StageRootLayerPath) {}
	public  FFilePath GetStageRootLayer() { return default; }
	public  void SetEditTarget(FFilePath EditTargetLayerPath) {}
	public  FFilePath GetEditTarget() { return default; }
	public  void Cleanup() {}
	public  bool ConvertLightComponent(ULightComponentBase Component,string PrimPath,float TimeCode/*=3.402823466e+38F*/) { return default; }
	public  bool ConvertDirectionalLightComponent(UDirectionalLightComponent Component,string PrimPath,float TimeCode/*=3.402823466e+38F*/) { return default; }
	public  bool ConvertRectLightComponent(URectLightComponent Component,string PrimPath,float TimeCode/*=3.402823466e+38F*/) { return default; }
	public  bool ConvertPointLightComponent(UPointLightComponent Component,string PrimPath,float TimeCode/*=3.402823466e+38F*/) { return default; }
	public  bool ConvertSkyLightComponent(USkyLightComponent Component,string PrimPath,float TimeCode/*=3.402823466e+38F*/) { return default; }
	public  bool ConvertSpotLightComponent(USpotLightComponent Component,string PrimPath,float TimeCode/*=3.402823466e+38F*/) { return default; }
	public  bool ConvertSceneComponent(USceneComponent Component,string PrimPath) { return default; }
	public  bool ConvertHismComponent(UHierarchicalInstancedStaticMeshComponent Component,string PrimPath,float TimeCode/*=3.402823466e+38F*/) { return default; }
	public  bool ConvertMeshComponent(UMeshComponent Component,string PrimPath) { return default; }
	public  bool ConvertCineCameraComponent(UCineCameraComponent Component,string PrimPath,float TimeCode/*=3.402823466e+38F*/) { return default; }
	public  bool ConvertInstancedFoliageActor(AInstancedFoliageActor Actor,string PrimPath,ULevel InstancesLevel/*=nullptr*/,float TimeCode/*=3.402823466e+38F*/) { return default; }
	public  bool ConvertLandscapeProxyActorMesh(ALandscapeProxy Actor,string PrimPath,int LowestLOD,int HighestLOD,float TimeCode/*=3.402823466e+38F*/) { return default; }
	public  bool ConvertLandscapeProxyActorMaterial(ALandscapeProxy Actor,string PrimPath,TArray<FPropertyEntry> PropertiesToBake,FIntPoint DefaultTextureSize,FDirectoryPath TexturesDir,float TimeCode/*=3.402823466e+38F*/) { return default; }
	public  void ReplaceUnrealMaterialsWithBaked(FFilePath LayerToAuthorIn,TMap<string,string> BakedMaterials,bool bIsAssetLayer,bool bUsePayload,bool bRemoveUnrealMaterials/*=false*/) {}
	public  bool RemoveUnrealSurfaceOutput(string PrimPath,FFilePath LayerToAuthorIn) { return default; }
	public  int GetUsdStageNumFrames() { return default; }
	public  void SetPrimAssetInfo(string PrimPath,FUsdUnrealAssetInfo Info) {}
	public  FUsdUnrealAssetInfo GetPrimAssetInfo(string PrimPath) { return default; }
}
