#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Wraps the UnrealToUsd component conversion functions from the USDUtilities module so that they can be used by</summary>
[CppInclude("USDConversionBlueprintContext.h")]
public partial class UUsdConversionBlueprintContext : UObject {
	///<summary>Opens or creates a USD stage using `StageRootLayerPath` as root layer, creating the root layer if needed.</summary>
	public  void SetStageRootLayer(FFilePath StageRootLayerPath) {}
	///<summary>Gets the file path of the root layer of our current stage</summary>
	public  FFilePath GetStageRootLayer() { return default; }
	///<summary>Sets the current edit target of our internal stage. When calling the conversion functions, prims and attributes</summary>
	public  void SetEditTarget(FFilePath EditTargetLayerPath) {}
	///<summary>Gets the filepath of the current edit target layer of our internal stage</summary>
	public  FFilePath GetEditTarget() { return default; }
	///<summary>Discards the currently opened stage. This is critical when using this class via scripting: The C++ destructor will</summary>
	public  void Cleanup() {}
	///<summary>Note: We use FLT_MAX on these functions because Usd.TimeCode.Default().GetValue() is actually a nan, and nan arguments are automatically sanitized to 0.0f.</summary>
	public  bool ConvertLightComponent(ULightComponentBase Component,string PrimPath,float TimeCode/*=3.402823466e+38F*/) { return default; }
	///<summary>ConvertDirectionalLightComponent</summary>
	public  bool ConvertDirectionalLightComponent(UDirectionalLightComponent Component,string PrimPath,float TimeCode/*=3.402823466e+38F*/) { return default; }
	///<summary>ConvertRectLightComponent</summary>
	public  bool ConvertRectLightComponent(URectLightComponent Component,string PrimPath,float TimeCode/*=3.402823466e+38F*/) { return default; }
	///<summary>ConvertPointLightComponent</summary>
	public  bool ConvertPointLightComponent(UPointLightComponent Component,string PrimPath,float TimeCode/*=3.402823466e+38F*/) { return default; }
	///<summary>ConvertSkyLightComponent</summary>
	public  bool ConvertSkyLightComponent(USkyLightComponent Component,string PrimPath,float TimeCode/*=3.402823466e+38F*/) { return default; }
	///<summary>ConvertSpotLightComponent</summary>
	public  bool ConvertSpotLightComponent(USpotLightComponent Component,string PrimPath,float TimeCode/*=3.402823466e+38F*/) { return default; }
	///<summary>ConvertSceneComponent</summary>
	public  bool ConvertSceneComponent(USceneComponent Component,string PrimPath) { return default; }
	///<summary>ConvertHismComponent</summary>
	public  bool ConvertHismComponent(UHierarchicalInstancedStaticMeshComponent Component,string PrimPath,float TimeCode/*=3.402823466e+38F*/) { return default; }
	///<summary>ConvertMeshComponent</summary>
	public  bool ConvertMeshComponent(UMeshComponent Component,string PrimPath) { return default; }
	///<summary>ConvertCineCameraComponent</summary>
	public  bool ConvertCineCameraComponent(UCineCameraComponent Component,string PrimPath,float TimeCode/*=3.402823466e+38F*/) { return default; }
	///<summary>ConvertInstancedFoliageActor</summary>
	public  bool ConvertInstancedFoliageActor(AInstancedFoliageActor Actor,string PrimPath,ULevel InstancesLevel/*=nullptr*/,float TimeCode/*=3.402823466e+38F*/) { return default; }
	///<summary>ConvertLandscapeProxyActorMesh</summary>
	public  bool ConvertLandscapeProxyActorMesh(ALandscapeProxy Actor,string PrimPath,int LowestLOD,int HighestLOD,float TimeCode/*=3.402823466e+38F*/) { return default; }
	///<summary>ConvertLandscapeProxyActorMaterial</summary>
	public  bool ConvertLandscapeProxyActorMaterial(ALandscapeProxy Actor,string PrimPath,TArray<FPropertyEntry> PropertiesToBake,FIntPoint DefaultTextureSize,FDirectoryPath TexturesDir,float TimeCode/*=3.402823466e+38F*/) { return default; }
	///<summary>Traverses the context&#39;s stage and authors material binding attributes for all `unrealMaterials` that were baked into USD material assets.</summary>
	public  void ReplaceUnrealMaterialsWithBaked(FFilePath LayerToAuthorIn,TMap<string,string> BakedMaterials,bool bIsAssetLayer,bool bUsePayload,bool bRemoveUnrealMaterials/*=false*/) {}
	///<summary>RemoveUnrealSurfaceOutput</summary>
	public  bool RemoveUnrealSurfaceOutput(string PrimPath,FFilePath LayerToAuthorIn) { return default; }
	///<summary>Returns how many frames of animation the stage would generate if imported</summary>
	public  int GetUsdStageNumFrames() { return default; }
	///<summary>Adds to Prim the assetInfo metadata the values described in Info</summary>
	public  void SetPrimAssetInfo(string PrimPath,FUsdUnrealAssetInfo Info) {}
	///<summary>Retrieves from Prim the assetInfo metadata values that we use as export metadata, when exporting Unreal assets</summary>
	public  FUsdUnrealAssetInfo GetPrimAssetInfo(string PrimPath) { return default; }
}
