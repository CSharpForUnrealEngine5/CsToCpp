#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Sets all selected bone&#39;s visibilty to Visible/Hidden</summary>
[CppInclude("Dataflow/GeometryCollectionEditNodes.h")]
public partial struct FSetVisibilityInCollectionDataflowNode {
	public EVisibiltyOptionsEnum Visibility;
	public FManagedArrayCollection Collection;
	public FDataflowTransformSelection TransformSelection;
	public FDataflowFaceSelection FaceSelection;
}
