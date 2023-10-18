namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldPartition/HLOD/HLODLayer.h")]
public partial class UHLODLayer : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Type of HLOD generation to use</summary>
	public EHLODLayerType LayerType;
	///<summary>HLOD Builder class</summary>
	public UClass HLODBuilderClass;
	///<summary>HLODBuilderSettings</summary>
	public UHLODBuilderSettings HLODBuilderSettings;
	///<summary>Whether HLOD actors generated for this layer will be spatially loaded</summary>
	public bool bIsSpatiallyLoaded;
	///<summary>Cell size of the runtime grid created to encompass HLOD actors generated for this HLOD Layer</summary>
	public int CellSize;
	///<summary>Loading range of the runtime grid created to encompass HLOD actors generated for this HLOD Layer</summary>
	public double LoadingRange;
	///<summary>HLOD Layer to assign to the generated HLOD actors</summary>
	public UHLODLayer ParentLayer;
	///<summary>Specify a custom HLOD Actor class, the default is AWorldPartitionHLOD</summary>
	public UClass HLODActorClass;
	///<summary>HLOD Modifier class, to allow changes to the HLOD at runtime</summary>
	public UClass HLODModifierClass;
	///<summary>MeshMergeSettings_DEPRECATED</summary>
	public FMeshMergingSettings MeshMergeSettings_DEPRECATED;
	///<summary>MeshSimplifySettings_DEPRECATED</summary>
	public FMeshProxySettings MeshSimplifySettings_DEPRECATED;
	///<summary>MeshApproximationSettings_DEPRECATED</summary>
	public FMeshApproximationSettings MeshApproximationSettings_DEPRECATED;
	///<summary>HLODMaterial_DEPRECATED</summary>
	public TSoftObjectPtr<UMaterialInterface> HLODMaterial_DEPRECATED;
	///<summary>bAlwaysLoaded_DEPRECATED</summary>
	public bool bAlwaysLoaded_DEPRECATED;
}
