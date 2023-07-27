#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NearestNeighborTrainingModel.h")]
public partial class UNearestNeighborTrainingModel : UMLDeformerTrainingModel {
// NearestNeighborTrainingModel
	public  int Train() { return default; }
	public  int UpdateNearestNeighborData() { return default; }
	public  int KmeansClusterPoses(int PartId) { return default; }
	public TArray<float> PartSampleDeltas;
	public TArray<int> KmeansResults;
	public  UNearestNeighborModel GetNearestNeighborModel() { return default; }
	public  TArray<int> GetPartVertexMap(int PartId) { return default; }
	public  int SamplePart(int PartId,int Index) { return default; }
	public  int SetSamplerPartData(int PartId) { return default; }
	public  int GetPartNumNeighbors(int PartId) { return default; }
	public  bool SampleKmeansAnim(int SkeletonId) { return default; }
	public  bool SampleKmeansFrame(int Frame) { return default; }
	public  int GetKmeansNumAnims() { return default; }
	public  int GetKmeansAnimNumFrames(int SkeletonId) { return default; }
	public  int GetKmeansNumClusters() { return default; }
	public  TArray<float> GetUnskinnedVertexPositions() { return default; }
	public  TArray<int> GetMeshIndexBuffer() { return default; }
}
