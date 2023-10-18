namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Generates a formatted string of the bones and the selection</summary>
[CppInclude("Dataflow/GeometryCollectionSelectionNodes.h")]
public partial struct FCollectionTransformSelectionInfoDataflowNode {
	public FDataflowTransformSelection TransformSelection;
	public FManagedArrayCollection Collection;
	public string String;
}
