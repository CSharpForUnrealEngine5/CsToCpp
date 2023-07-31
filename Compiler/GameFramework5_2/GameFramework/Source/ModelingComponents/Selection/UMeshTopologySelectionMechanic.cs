#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class mechanic for selecting a subset of mesh elements (edge loops, groups, corners, etc.)</summary>
[CppInclude("Selection/MeshTopologySelectionMechanic.h")]
public partial class UMeshTopologySelectionMechanic : UInteractionMechanic {
	///<summary>TODO: Is it worth issuing separate callbacks in normal selection changes and in FChange ones, to</summary>
	public UMeshTopologySelectionMechanicProperties Properties;
	///<summary>HoverBehavior</summary>
	public UMouseHoverBehavior HoverBehavior;
	///<summary>ClickOrDragBehavior</summary>
	public USingleClickOrDragInputBehavior ClickOrDragBehavior;
	///<summary>MarqueeMechanic</summary>
	public URectangleMarqueeMechanic MarqueeMechanic;
	///<summary>The actor we create internally to own the DrawnTriangleSetComponent</summary>
	public APreviewGeometryActor PreviewGeometryActor;
	///<summary>DrawnTriangleSetComponent</summary>
	public UTriangleSetComponent DrawnTriangleSetComponent;
	///<summary>HighlightedFaceMaterial</summary>
	public UMaterialInterface HighlightedFaceMaterial;
}
