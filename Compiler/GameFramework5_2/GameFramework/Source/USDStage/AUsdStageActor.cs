#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("USDStageActor.h")]
public partial class AUsdStageActor : AActor {
	///<summary>RootLayer</summary>
	public FFilePath RootLayer;
	///<summary>UsdAssetCache</summary>
	public UUsdAssetCache2 UsdAssetCache;
	///<summary>These properties are configs so that spawned actors read them from the CDO when spawned.</summary>
	public EUsdInitialLoadSet InitialLoadSet;
	///<summary>InterpolationType</summary>
	public EUsdInterpolationType InterpolationType;
	///<summary>Whether to try to combine individual assets and components of the same type on a kind-per-kind basis,</summary>
	public int KindsToCollapse;
	///<summary>If enabled, when multiple mesh prims are collapsed into a single static mesh, identical material slots are merged into one slot.</summary>
	public bool bMergeIdenticalMaterialSlots;
	///<summary>bCollapseTopLevelPointInstancers</summary>
	public bool bCollapseTopLevelPointInstancers;
	///<summary>Only load prims with these specific purposes from the USD file</summary>
	public int PurposesToLoad;
	///<summary>Try enabling Nanite for static meshes that are generated with at least this many triangles</summary>
	public int NaniteTriangleThreshold;
	///<summary>Specifies which set of shaders to use when parsing USD materials, in addition to the universal render context.</summary>
	public string RenderContext;
	///<summary>Specifies which material purbose to use when parsing USD material bindings, in addition to the &quot;allPurpose&quot; fallback.</summary>
	public string MaterialPurpose;
	///<summary>Describes what to add to the root bone animation within generated AnimSequences, if anything</summary>
	public EUsdRootMotionHandling RootMotionHandling;
	///<summary>SetRootLayer</summary>
	public  void SetRootLayer(string RootFilePath) {}
	///<summary>SetAssetCache</summary>
	public  void SetAssetCache(UUsdAssetCache2 NewCache) {}
	///<summary>SetInitialLoadSet</summary>
	public  void SetInitialLoadSet(EUsdInitialLoadSet NewLoadSet) {}
	///<summary>SetInterpolationType</summary>
	public  void SetInterpolationType(EUsdInterpolationType NewType) {}
	///<summary>SetKindsToCollapse</summary>
	public  void SetKindsToCollapse(int NewKindsToCollapse) {}
	///<summary>SetMergeIdenticalMaterialSlots</summary>
	public  void SetMergeIdenticalMaterialSlots(bool bMerge) {}
	///<summary>SetCollapseTopLevelPointInstancers</summary>
	public  void SetCollapseTopLevelPointInstancers(bool bCollapse) {}
	///<summary>SetPurposesToLoad</summary>
	public  void SetPurposesToLoad(int NewPurposesToLoad) {}
	///<summary>SetNaniteTriangleThreshold</summary>
	public  void SetNaniteTriangleThreshold(int NewNaniteTriangleThreshold) {}
	///<summary>SetRenderContext</summary>
	public  void SetRenderContext(string NewRenderContext) {}
	///<summary>SetMaterialPurpose</summary>
	public  void SetMaterialPurpose(string NewMaterialPurpose) {}
	///<summary>SetRootMotionHandling</summary>
	public  void SetRootMotionHandling(EUsdRootMotionHandling NewHandlingStrategy) {}
	///<summary>GetTime</summary>
	public  float GetTime() { return default; }
	///<summary>SetTime</summary>
	public  void SetTime(float InTime) {}
	///<summary>GetLevelSequence</summary>
	public  ULevelSequence GetLevelSequence() { return default; }
	///<summary>Gets the transient component that was generated for a prim with a given prim path.</summary>
	public  USceneComponent GetGeneratedComponent(string PrimPath) { return default; }
	///<summary>Gets the transient assets that were generated for a prim with a given prim path. Likely one asset (e.g. UStaticMesh), but can be multiple (USkeletalMesh, USkeleton, etc.)</summary>
	public  TArray<UObject> GetGeneratedAssets(string PrimPath) { return default; }
	///<summary>Gets the path to the prim that was parsed to generate the given `Object`.</summary>
	public  string GetSourcePrimPath(UObject Object) { return default; }
	///<summary>Creates a brand new, memory-only USD stage and opens it</summary>
	public  void NewStage() {}
	///<summary>If IsolatedStageRootLayer is the identifier of one of the sublayers of the currently opened stage, this will</summary>
	public  void SetIsolatedRootLayer(string IsolatedStageRootLayer) {}
	///<summary>Returns the root layer identifier of the currently isolated stage if we&#39;re in isolated mode, and the empty</summary>
	public  string GetIsolatedRootLayer() { return default; }
	///<summary>SceneComponent</summary>
	public USceneComponent SceneComponent;
	///<summary>TimeCode to evaluate the USD stage at</summary>
	public float Time;
	///<summary>LevelSequence</summary>
	public ULevelSequence LevelSequence;
	///<summary>Note: This cannot be instanced: Read the comment in the constructor</summary>
	public UUsdPrimTwin RootUsdTwin;
	///<summary>PrimsToAnimate</summary>
	public TSet<string> PrimsToAnimate;
	///<summary>ObjectsToWatch</summary>
	public TMap<UObject,string> ObjectsToWatch;
	///<summary>AssetCache</summary>
	public UUsdAssetCache AssetCache;
	///<summary>Transactor</summary>
	public UUsdTransactor Transactor;
}
