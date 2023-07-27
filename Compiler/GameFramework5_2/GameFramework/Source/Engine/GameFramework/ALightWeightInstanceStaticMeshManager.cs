#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/LightWeightInstanceStaticMeshManager.h")]
public partial class ALightWeightInstanceStaticMeshManager : ALightWeightInstanceManager {
// LightWeightInstanceStaticMeshManager
	public TSoftObjectPtr<UStaticMesh> StaticMesh;
	public  void OnRep_StaticMesh() {}
	public UHierarchicalInstancedStaticMeshComponent InstancedStaticMeshComponent;
	public TArray<int> RenderingIndicesToDataIndices;
	public TArray<int> DataIndicesToRenderingIndices;
}
