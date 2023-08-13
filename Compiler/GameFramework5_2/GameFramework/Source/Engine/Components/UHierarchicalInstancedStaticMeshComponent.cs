namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/HierarchicalInstancedStaticMeshComponent.h")]
public partial class UHierarchicalInstancedStaticMeshComponent : UInstancedStaticMeshComponent {
	public static UClass StaticClass() {return default;}
	///<summary>If true then we allow a translated space when building the cluster tree.</summary>
	public bool bUseTranslatedInstanceSpace;
	///<summary>Origin of the translated space used when building the cluster tree.</summary>
	public FVector TranslatedInstanceSpaceOrigin;
	///<summary>Table for remapping instances from cluster tree to PerInstanceSMData order</summary>
	public TArray<int> SortedInstances;
	///<summary>The number of instances in the ClusterTree. Subsequent instances will always be rendered.</summary>
	public int NumBuiltInstances;
	///<summary>Bounding box of any built instances (cached from the ClusterTree)</summary>
	public FBox BuiltInstanceBounds;
	///<summary>Bounding box of any unbuilt instances</summary>
	public FBox UnbuiltInstanceBounds;
	///<summary>Bounds of each individual unbuilt instance, used for LOD calculation</summary>
	public TArray<FBox> UnbuiltInstanceBoundsList;
	///<summary>Enable for detail meshes that don&#39;t really affect the game. Disable for anything important.</summary>
	public bool bEnableDensityScaling;
	///<summary>The number of nodes in the occlusion layer</summary>
	public int OcclusionLayerNumNodes;
	///<summary>The last mesh bounds that was cache</summary>
	public FBoxSphereBounds CacheMeshExtendedBounds;
	///<summary>bDisableCollision</summary>
	public bool bDisableCollision;
	///<summary>Instances to render (including removed one until the build is complete)</summary>
	public int InstanceCountToRender;
}
