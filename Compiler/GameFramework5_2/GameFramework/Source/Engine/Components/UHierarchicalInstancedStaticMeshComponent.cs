#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/HierarchicalInstancedStaticMeshComponent.h")]
public partial class UHierarchicalInstancedStaticMeshComponent : UInstancedStaticMeshComponent {
// HierarchicalInstancedStaticMeshComponent
	public bool bUseTranslatedInstanceSpace;
	public FVector TranslatedInstanceSpaceOrigin;
	public TArray<int> SortedInstances;
	public int NumBuiltInstances;
	public FBox BuiltInstanceBounds;
	public FBox UnbuiltInstanceBounds;
	public TArray<FBox> UnbuiltInstanceBoundsList;
	public bool bEnableDensityScaling;
	public int OcclusionLayerNumNodes;
	public FBoxSphereBounds CacheMeshExtendedBounds;
	public bool bDisableCollision;
	public int InstanceCountToRender;
}
