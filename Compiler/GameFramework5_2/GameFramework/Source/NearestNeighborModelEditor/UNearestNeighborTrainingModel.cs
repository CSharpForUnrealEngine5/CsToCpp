#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NearestNeighborTrainingModel.h")]
public partial class UNearestNeighborTrainingModel : UMLDeformerTrainingModel {
	public static UClass StaticClass() {return default;}
	///<summary>Main training function, with implementation in python.</summary>
	public  int Train() { return default; }
	///<summary>UpdateNearestNeighborData</summary>
	public  int UpdateNearestNeighborData() { return default; }
	///<summary>KmeansClusterPoses</summary>
	public  int KmeansClusterPoses(int PartId) { return default; }
	///<summary>PartSampleDeltas</summary>
	public TArray<float> PartSampleDeltas;
	///<summary>KmeansResults</summary>
	public TArray<int> KmeansResults;
	///<summary>GetNearestNeighborModel</summary>
	public  UNearestNeighborModel GetNearestNeighborModel() { return default; }
	///<summary>GetPartVertexMap</summary>
	public  TArray<int> GetPartVertexMap(int PartId) { return default; }
	///<summary>SamplePart</summary>
	public  int SamplePart(int PartId,int Index) { return default; }
	///<summary>SetSamplerPartData</summary>
	public  int SetSamplerPartData(int PartId) { return default; }
	///<summary>GetPartNumNeighbors</summary>
	public  int GetPartNumNeighbors(int PartId) { return default; }
	///<summary>SampleKmeansAnim</summary>
	public  bool SampleKmeansAnim(int SkeletonId) { return default; }
	///<summary>SampleKmeansFrame</summary>
	public  bool SampleKmeansFrame(int Frame) { return default; }
	///<summary>GetKmeansNumAnims</summary>
	public  int GetKmeansNumAnims() { return default; }
	///<summary>GetKmeansAnimNumFrames</summary>
	public  int GetKmeansAnimNumFrames(int SkeletonId) { return default; }
	///<summary>GetKmeansNumClusters</summary>
	public  int GetKmeansNumClusters() { return default; }
	///<summary>GetUnskinnedVertexPositions</summary>
	public  TArray<float> GetUnskinnedVertexPositions() { return default; }
	///<summary>GetMeshIndexBuffer</summary>
	public  TArray<int> GetMeshIndexBuffer() { return default; }
}
