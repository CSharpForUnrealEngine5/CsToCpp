#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/LightWeightInstanceStaticMeshManager.h")]
public partial class ALightWeightInstanceStaticMeshManager : ALightWeightInstanceManager {
	public static UClass StaticClass() {return default;}
	///<summary>StaticMesh</summary>
	public TSoftObjectPtr<UStaticMesh> StaticMesh;
	///<summary>OnRep_StaticMesh</summary>
	public  void OnRep_StaticMesh() {}
	///<summary>InstancedStaticMeshComponent</summary>
	public UHierarchicalInstancedStaticMeshComponent InstancedStaticMeshComponent;
	///<summary>keep track of the relationship between our data and the rendering data stored in the instanced static mesh component</summary>
	public TArray<int> RenderingIndicesToDataIndices;
	///<summary>DataIndicesToRenderingIndices</summary>
	public TArray<int> DataIndicesToRenderingIndices;
}
