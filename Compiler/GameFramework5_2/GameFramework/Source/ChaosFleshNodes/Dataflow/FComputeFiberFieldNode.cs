#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dataflow/ChaosFleshEngineAssetNodes.h")]
///<summary>Computes a muscle fiber direction per tetrahedron from a GeometryCollection containing tetrahedra,</summary>
public partial struct FComputeFiberFieldNode {
// ComputeFiberFieldNode
	public FManagedArrayCollection Collection;
	public TArray<int> OriginIndices;
	public TArray<int> InsertionIndices;
	public string OriginInsertionGroupName;
	public string OriginVertexFieldName;
	public string InsertionVertexFieldName;
	public int MaxIterations;
	public float Tolerance;
}
