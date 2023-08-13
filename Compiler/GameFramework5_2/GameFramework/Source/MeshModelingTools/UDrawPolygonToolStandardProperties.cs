namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DrawPolygonTool.h")]
public partial class UDrawPolygonToolStandardProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Type of polygon to draw in the viewport</summary>
	public EDrawPolygonDrawMode PolygonDrawMode;
	///<summary>Allow freehand drawn polygons to self-intersect</summary>
	public bool bAllowSelfIntersections;
	///<summary>Size of secondary features, e.g. the rounded corners of a rounded rectangle, as fraction of the overall shape size</summary>
	public float FeatureSizeRatio;
	///<summary>Number of radial subdivisions in round features, e.g. circles or rounded corners</summary>
	public int RadialSlices;
	///<summary>Distance between the last clicked point and the current point</summary>
	public float Distance;
	///<summary>If true, shows a gizmo to manipulate the additional grid used to draw the polygon on</summary>
	public bool bShowGridGizmo;
	///<summary>If and how the drawn polygon gets extruded</summary>
	public EDrawPolygonExtrudeMode ExtrudeMode;
	///<summary>Extrude distance when using the Fixed extrude mode</summary>
	public float ExtrudeHeight;
}
