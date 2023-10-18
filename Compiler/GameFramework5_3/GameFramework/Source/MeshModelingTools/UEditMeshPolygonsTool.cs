namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EditMeshPolygonsTool.h")]
public partial class UEditMeshPolygonsTool : USingleTargetWithSelectionTool {
	public static UClass StaticClass() {return default;}
	///<summary>Preview</summary>
	public UMeshOpPreviewWithBackgroundCompute Preview;
	///<summary>CommonProps</summary>
	public UPolyEditCommonProperties CommonProps;
	///<summary>EditActions</summary>
	public UEditMeshPolygonsToolActions EditActions;
	///<summary>EditActions_Triangles</summary>
	public UEditMeshPolygonsToolActions_Triangles EditActions_Triangles;
	///<summary>EditEdgeActions</summary>
	public UEditMeshPolygonsToolEdgeActions EditEdgeActions;
	///<summary>EditEdgeActions_Triangles</summary>
	public UEditMeshPolygonsToolEdgeActions_Triangles EditEdgeActions_Triangles;
	///<summary>EditUVActions</summary>
	public UEditMeshPolygonsToolUVActions EditUVActions;
	///<summary>CancelAction</summary>
	public UEditMeshPolygonsToolCancelAction CancelAction;
	///<summary>AcceptCancelAction</summary>
	public UEditMeshPolygonsToolAcceptCancelAction AcceptCancelAction;
	///<summary>TopologyProperties</summary>
	public UPolyEditTopologyProperties TopologyProperties;
	///<summary>Activity objects that handle multi-interaction operations</summary>
	public UPolyEditExtrudeActivity ExtrudeActivity;
	///<summary>InsetOutsetActivity</summary>
	public UPolyEditInsetOutsetActivity InsetOutsetActivity;
	///<summary>CutFacesActivity</summary>
	public UPolyEditCutFacesActivity CutFacesActivity;
	///<summary>PlanarProjectionUVActivity</summary>
	public UPolyEditPlanarProjectionUVActivity PlanarProjectionUVActivity;
	///<summary>InsertEdgeActivity</summary>
	public UPolyEditInsertEdgeActivity InsertEdgeActivity;
	///<summary>InsertEdgeLoopActivity</summary>
	public UPolyEditInsertEdgeLoopActivity InsertEdgeLoopActivity;
	///<summary>BevelEdgeActivity</summary>
	public UPolyEditBevelEdgeActivity BevelEdgeActivity;
	///<summary>ActivityContext</summary>
	public UPolyEditActivityContext ActivityContext;
	///<summary>SelectionMechanic</summary>
	public UPolygonSelectionMechanic SelectionMechanic;
	///<summary>DragAlignmentMechanic</summary>
	public UDragAlignmentMechanic DragAlignmentMechanic;
	///<summary>TransformGizmo</summary>
	public UCombinedTransformGizmo TransformGizmo;
	///<summary>TransformProxy</summary>
	public UTransformProxy TransformProxy;
}
