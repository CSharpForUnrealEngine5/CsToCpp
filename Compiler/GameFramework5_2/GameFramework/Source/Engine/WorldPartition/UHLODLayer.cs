#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldPartition/HLOD/HLODLayer.h")]
public partial class UHLODLayer : UObject {
// HLODLayer
	public EHLODLayerType LayerType;
	public UClass HLODBuilderClass;
	public UHLODBuilderSettings HLODBuilderSettings;
	public bool bIsSpatiallyLoaded;
	public int CellSize;
	public double LoadingRange;
	public TSoftObjectPtr<UHLODLayer> ParentLayer;
	public UClass HLODModifierClass;
	public FMeshMergingSettings MeshMergeSettings_DEPRECATED;
	public FMeshProxySettings MeshSimplifySettings_DEPRECATED;
	public FMeshApproximationSettings MeshApproximationSettings_DEPRECATED;
	public TSoftObjectPtr<UMaterialInterface> HLODMaterial_DEPRECATED;
	public bool bAlwaysLoaded_DEPRECATED;
}
