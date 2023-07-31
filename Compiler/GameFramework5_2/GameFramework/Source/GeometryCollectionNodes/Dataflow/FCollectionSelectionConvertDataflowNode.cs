#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Converts Vertex/Face/Transform selection into Vertex/Face/Transform selection</summary>
[CppInclude("Dataflow/GeometryCollectionSelectionNodes.h")]
public partial struct FCollectionSelectionConvertDataflowNode {
	public FManagedArrayCollection Collection;
	public FDataflowTransformSelection TransformSelection;
	public FDataflowFaceSelection FaceSelection;
	public FDataflowVertexSelection VertexSelection;
	public bool bAllElementsMustBeSelected;
}
