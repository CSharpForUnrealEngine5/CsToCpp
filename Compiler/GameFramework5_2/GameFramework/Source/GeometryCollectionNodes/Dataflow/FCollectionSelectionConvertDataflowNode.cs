#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dataflow/GeometryCollectionSelectionNodes.h")]
///<summary>Converts Vertex/Face/Transform selection into Vertex/Face/Transform selection</summary>
public partial struct FCollectionSelectionConvertDataflowNode {
// CollectionSelectionConvertDataflowNode
	public FManagedArrayCollection Collection;
	public FDataflowTransformSelection TransformSelection;
	public FDataflowFaceSelection FaceSelection;
	public FDataflowVertexSelection VertexSelection;
	public bool bAllElementsMustBeSelected;
}
