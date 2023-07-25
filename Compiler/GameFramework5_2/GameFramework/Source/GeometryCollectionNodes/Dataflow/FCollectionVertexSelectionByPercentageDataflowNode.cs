#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dataflow/GeometryCollectionSelectionNodes.h")]
///<summary>Outputs the specified percentage of the selected vertices</summary>
public partial struct FCollectionVertexSelectionByPercentageDataflowNode {
// CollectionVertexSelectionByPercentageDataflowNode
	public FDataflowVertexSelection VertexSelection;
	public int Percentage;
	public bool bDeterministic;
	public float RandomSeed;
}
