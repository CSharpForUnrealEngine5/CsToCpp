namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Selects specified vertices in the GeometryCollection by using a</summary>
[CppInclude("Dataflow/GeometryCollectionSelectionNodes.h")]
public partial struct FCollectionVertexSelectionCustomDataflowNode {
	public FManagedArrayCollection Collection;
	public string VertexIndicies;
	public FDataflowVertexSelection VertexSelection;
}
