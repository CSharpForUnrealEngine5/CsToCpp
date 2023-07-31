#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The MeshTrackerComponent class manages requests for environmental mesh data, processes the results and provides</summary>
[CppInclude("MockDataMeshTrackerComponent.h")]
public partial class UMockDataMeshTrackerComponent : USceneComponent {
	///<summary>Sets the procedural mesh component that will store and display the environmental mesh results.</summary>
	public  void ConnectMRMesh(UMRMeshComponent InMRMeshPtr) {}
	///<summary>Unlinks the current procedural mesh component from the mesh tracking system.</summary>
	public  void DisconnectMRMesh(UMRMeshComponent InMRMeshPtr) {}
	///<summary>Delegate used by OnMeshUpdated().</summary>
	public  void FOnMockDataMeshTrackerUpdated(int Index,TArray<FVector> Vertices,TArray<int> Triangles,TArray<FVector> Normals,TArray<float> Confidence) {}
	///<summary>Activated whenever new information about this mesh tracker is detected.</summary>
	public FOnMockDataMeshTrackerUpdated OnMeshTrackerUpdated;
	///<summary>Set to true to start scanning the world for meshes.</summary>
	public bool ScanWorld;
	///<summary>If true, the system will generate normals for the triangle vertices.</summary>
	public bool RequestNormals;
	///<summary>If true, the system will generate the mesh confidence values for the triangle vertices.</summary>
	public bool RequestVertexConfidence;
	///<summary>Vertex Colors can be unused, or filled with several types of information.</summary>
	public EMeshTrackerVertexColorMode VertexColorMode;
	///<summary>Colors through which we cycle when setting vertex color by block.</summary>
	public TArray<FColor> BlockVertexColors;
	///<summary>Color mapped to confidence value of zero.</summary>
	public FLinearColor VertexColorFromConfidenceZero;
	///<summary>Color mapped to confidence value of one.</summary>
	public FLinearColor VertexColorFromConfidenceOne;
	///<summary>Update Interval in Seconds.</summary>
	public float UpdateInterval;
	///<summary>MRMeshComponent can render and provide collision based on the Mesh data.</summary>
	public UMRMeshComponent MRMesh;
}
