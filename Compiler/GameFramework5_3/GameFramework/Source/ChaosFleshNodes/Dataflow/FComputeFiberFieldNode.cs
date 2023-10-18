namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Computes a muscle fiber direction per tetrahedron from a GeometryCollection containing tetrahedra,</summary>
[CppInclude("Dataflow/ChaosFleshEngineAssetNodes.h")]
public partial struct FComputeFiberFieldNode {
	public FManagedArrayCollection Collection;
	public TArray<int> OriginIndices;
	public TArray<int> InsertionIndices;
	public string OriginInsertionGroupName;
	public string OriginVertexFieldName;
	public string InsertionVertexFieldName;
	public int MaxIterations;
	public float Tolerance;
}
