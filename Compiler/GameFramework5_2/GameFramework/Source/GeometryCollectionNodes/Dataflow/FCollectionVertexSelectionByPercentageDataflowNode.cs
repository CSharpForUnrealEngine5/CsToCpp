#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Outputs the specified percentage of the selected vertices</summary>
[CppInclude("Dataflow/GeometryCollectionSelectionNodes.h")]
public partial struct FCollectionVertexSelectionByPercentageDataflowNode {
	public FDataflowVertexSelection VertexSelection;
	public int Percentage;
	public bool bDeterministic;
	public float RandomSeed;
}
