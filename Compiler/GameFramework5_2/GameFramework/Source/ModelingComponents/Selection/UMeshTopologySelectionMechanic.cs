#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Selection/MeshTopologySelectionMechanic.h")]
///<summary>Base class mechanic for selecting a subset of mesh elements (edge loops, groups, corners, etc.)</summary>
public partial class UMeshTopologySelectionMechanic : UInteractionMechanic {
// MeshTopologySelectionMechanic
	public UMeshTopologySelectionMechanicProperties Properties;
	public UMouseHoverBehavior HoverBehavior;
	public USingleClickOrDragInputBehavior ClickOrDragBehavior;
	public URectangleMarqueeMechanic MarqueeMechanic;
	public APreviewGeometryActor PreviewGeometryActor;
	public UTriangleSetComponent DrawnTriangleSetComponent;
	public UMaterialInterface HighlightedFaceMaterial;
}
