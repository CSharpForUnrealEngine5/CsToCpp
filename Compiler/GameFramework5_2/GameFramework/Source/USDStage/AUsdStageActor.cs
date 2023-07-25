#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("USDStageActor.h")]
public partial class AUsdStageActor : AActor {
// UsdStageActor
	public FFilePath RootLayer;
	public UUsdAssetCache2 UsdAssetCache;
	public EUsdInitialLoadSet InitialLoadSet;
	public EUsdInterpolationType InterpolationType;
	public int KindsToCollapse;
	public bool bMergeIdenticalMaterialSlots;
	public bool bCollapseTopLevelPointInstancers;
	public int PurposesToLoad;
	public int NaniteTriangleThreshold;
	public string RenderContext;
	public string MaterialPurpose;
	public EUsdRootMotionHandling RootMotionHandling;
	public void SetRootLayer(string RootFilePath) {}
	public void SetAssetCache(UObject NewCache) {}
	public void SetInitialLoadSet(EUsdInitialLoadSet NewLoadSet) {}
	public void SetInterpolationType(EUsdInterpolationType NewType) {}
	public void SetKindsToCollapse(int NewKindsToCollapse) {}
	public void SetMergeIdenticalMaterialSlots(bool bMerge) {}
	public void SetCollapseTopLevelPointInstancers(bool bCollapse) {}
	public void SetPurposesToLoad(int NewPurposesToLoad) {}
	public void SetNaniteTriangleThreshold(int NewNaniteTriangleThreshold) {}
	public void SetRenderContext(string NewRenderContext) {}
	public void SetMaterialPurpose(string NewMaterialPurpose) {}
	public void SetRootMotionHandling(EUsdRootMotionHandling NewHandlingStrategy) {}
	public float GetTime() { return default; }
	public void SetTime(float InTime) {}
	public UObject GetLevelSequence() { return default; }
	public UObject GetGeneratedComponent(string PrimPath) { return default; }
	public TArray<UObject> GetGeneratedAssets(string PrimPath) { return default; }
	public string GetSourcePrimPath(UObject Object) { return default; }
	public void NewStage() {}
	public void SetIsolatedRootLayer(string IsolatedStageRootLayer) {}
	public string GetIsolatedRootLayer() { return default; }
	public USceneComponent SceneComponent;
	public float Time;
	public ULevelSequence LevelSequence;
	public UUsdPrimTwin RootUsdTwin;
	public TSet<string> PrimsToAnimate;
	public TMap<UObject,string> ObjectsToWatch;
	public UUsdAssetCache AssetCache;
	public UUsdTransactor Transactor;
}
