#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dataflow/GeometryCollectionEditNodes.h")]
///<summary>Sets all selected bone's visibilty to Visible/Hidden</summary>
public partial struct FSetVisibilityInCollectionDataflowNode {
// SetVisibilityInCollectionDataflowNode
	public EVisibiltyOptionsEnum Visibility;
	public FManagedArrayCollection Collection;
	public FDataflowTransformSelection TransformSelection;
	public FDataflowFaceSelection FaceSelection;
}
