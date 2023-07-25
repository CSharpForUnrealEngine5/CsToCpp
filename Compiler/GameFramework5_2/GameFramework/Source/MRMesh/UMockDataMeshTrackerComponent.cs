#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MockDataMeshTrackerComponent.h")]
///<summary>The MeshTrackerComponent class manages requests for environmental mesh data, processes the results and provides</summary>
public partial class UMockDataMeshTrackerComponent : USceneComponent {
// MockDataMeshTrackerComponent
	public void ConnectMRMesh(UObject InMRMeshPtr) {}
	public void DisconnectMRMesh(UObject InMRMeshPtr) {}
	public void FOnMockDataMeshTrackerUpdated(int Index,TArray<FVector> Vertices,TArray<int> Triangles,TArray<FVector> Normals,TArray<float> Confidence) {}
	public FOnMockDataMeshTrackerUpdated OnMeshTrackerUpdated;
	public bool ScanWorld;
	public bool RequestNormals;
	public bool RequestVertexConfidence;
	public EMeshTrackerVertexColorMode VertexColorMode;
	public TArray<FColor> BlockVertexColors;
	public FLinearColor VertexColorFromConfidenceZero;
	public FLinearColor VertexColorFromConfidenceOne;
	public float UpdateInterval;
	public UMRMeshComponent MRMesh;
}
