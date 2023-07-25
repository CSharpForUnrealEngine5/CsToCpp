#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dataflow/ChaosFleshEngineAssetNodes.h")]
///<summary>Given two sets of vertex indices, generate two sets of vertex indices for origins and insertions that are within X distance away.</summary>
public partial struct FGenerateOriginInsertionNode {
// GenerateOriginInsertionNode
	public FManagedArrayCollection Collection;
	public TArray<int> OriginIndicesIn;
	public TArray<int> InsertionIndicesIn;
	public TArray<int> OriginIndicesOut;
	public TArray<int> InsertionIndicesOut;
	public float Radius;
}
