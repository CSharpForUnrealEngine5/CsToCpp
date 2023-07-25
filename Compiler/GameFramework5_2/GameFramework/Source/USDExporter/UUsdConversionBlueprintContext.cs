#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("USDConversionBlueprintContext.h")]
///<summary>Wraps the UnrealToUsd component conversion functions from the USDUtilities module so that they can be used by</summary>
public partial class UUsdConversionBlueprintContext : UObject {
// UsdConversionBlueprintContext
	public void SetStageRootLayer(FFilePath StageRootLayerPath) {}
	public FFilePath GetStageRootLayer() { return default; }
	public void SetEditTarget(FFilePath EditTargetLayerPath) {}
	public FFilePath GetEditTarget() { return default; }
	public void Cleanup() {}
	public bool ConvertLightComponent(UObject Component,string PrimPath,float TimeCode/*=3.402823466e+38F*/) { return default; }
	public bool ConvertDirectionalLightComponent(UObject Component,string PrimPath,float TimeCode/*=3.402823466e+38F*/) { return default; }
	public bool ConvertRectLightComponent(UObject Component,string PrimPath,float TimeCode/*=3.402823466e+38F*/) { return default; }
	public bool ConvertPointLightComponent(UObject Component,string PrimPath,float TimeCode/*=3.402823466e+38F*/) { return default; }
	public bool ConvertSkyLightComponent(UObject Component,string PrimPath,float TimeCode/*=3.402823466e+38F*/) { return default; }
	public bool ConvertSpotLightComponent(UObject Component,string PrimPath,float TimeCode/*=3.402823466e+38F*/) { return default; }
	public bool ConvertSceneComponent(UObject Component,string PrimPath) { return default; }
	public bool ConvertHismComponent(UObject Component,string PrimPath,float TimeCode/*=3.402823466e+38F*/) { return default; }
	public bool ConvertMeshComponent(UObject Component,string PrimPath) { return default; }
	public bool ConvertCineCameraComponent(UObject Component,string PrimPath,float TimeCode/*=3.402823466e+38F*/) { return default; }
	public bool ConvertInstancedFoliageActor(UObject Actor,string PrimPath,UObject InstancesLevel/*=nullptr*/,float TimeCode/*=3.402823466e+38F*/) { return default; }
	public bool ConvertLandscapeProxyActorMesh(UObject Actor,string PrimPath,int LowestLOD,int HighestLOD,float TimeCode/*=3.402823466e+38F*/) { return default; }
	public bool ConvertLandscapeProxyActorMaterial(UObject Actor,string PrimPath,TArray<FPropertyEntry> PropertiesToBake,FIntPoint DefaultTextureSize,FDirectoryPath TexturesDir,float TimeCode/*=3.402823466e+38F*/) { return default; }
	public void ReplaceUnrealMaterialsWithBaked(FFilePath LayerToAuthorIn,TMap<string,string> BakedMaterials,bool bIsAssetLayer,bool bUsePayload,bool bRemoveUnrealMaterials/*=false*/) {}
	public bool RemoveUnrealSurfaceOutput(string PrimPath,FFilePath LayerToAuthorIn) { return default; }
	public int GetUsdStageNumFrames() { return default; }
	public void SetPrimAssetInfo(string PrimPath,FUsdUnrealAssetInfo Info) {}
	public FUsdUnrealAssetInfo GetPrimAssetInfo(string PrimPath) { return default; }
}
