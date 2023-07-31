#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Given two sets of vertex indices, generate two sets of vertex indices for origins and insertions that are within X distance away.</summary>
[CppInclude("Dataflow/ChaosFleshEngineAssetNodes.h")]
public partial struct FGenerateOriginInsertionNode {
	public FManagedArrayCollection Collection;
	public TArray<int> OriginIndicesIn;
	public TArray<int> InsertionIndicesIn;
	public TArray<int> OriginIndicesOut;
	public TArray<int> InsertionIndicesOut;
	public float Radius;
}
