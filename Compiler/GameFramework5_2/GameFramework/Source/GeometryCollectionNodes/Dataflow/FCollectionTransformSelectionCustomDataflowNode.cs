namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Selects specified bones in the GeometryCollection by using a</summary>
[CppInclude("Dataflow/GeometryCollectionSelectionNodes.h")]
public partial struct FCollectionTransformSelectionCustomDataflowNode {
	public FManagedArrayCollection Collection;
	public string BoneIndicies;
	public FDataflowTransformSelection TransformSelection;
}
