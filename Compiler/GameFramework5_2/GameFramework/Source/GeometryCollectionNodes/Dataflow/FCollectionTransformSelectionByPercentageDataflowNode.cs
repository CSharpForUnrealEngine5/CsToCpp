namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Outputs the specified percentage of the selected bones</summary>
[CppInclude("Dataflow/GeometryCollectionSelectionNodes.h")]
public partial struct FCollectionTransformSelectionByPercentageDataflowNode {
	public FDataflowTransformSelection TransformSelection;
	public int Percentage;
	public bool bDeterministic;
	public float RandomSeed;
}
