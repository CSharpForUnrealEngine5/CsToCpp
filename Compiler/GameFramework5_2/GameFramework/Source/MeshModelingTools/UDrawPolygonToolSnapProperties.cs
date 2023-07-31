#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DrawPolygonTool.h")]
public partial class UDrawPolygonToolSnapProperties : UInteractiveToolPropertySet {
	///<summary>Enables additional snapping controls. If false, all snapping is disabled.</summary>
	public bool bEnableSnapping;
	///<summary>bSnapToWorldGrid</summary>
	public bool bSnapToWorldGrid;
	///<summary>Snap to vertices in other meshes. Requires Enable Snapping to be true.</summary>
	public bool bSnapToVertices;
	///<summary>Snap to edges in other meshes. Requires Enable Snapping to be true.</summary>
	public bool bSnapToEdges;
	///<summary>Snap to axes of the drawing grid and axes relative to the last segment. Requires grid snapping to be disabled in viewport, and Enable Snapping to be true.</summary>
	public bool bSnapToAxes;
	///<summary>When snapping to axes, also try to snap to the length of an existing segment in the polygon. Requires grid snapping to be disabled in viewport, and Snap to Axes and Enable Snapping to be true.</summary>
	public bool bSnapToLengths;
	///<summary>Snap to surfaces of existing objects. Requires grid snapping to be disabled in viewport, and Enable Snapping to be true.</summary>
	public bool bSnapToSurfaces;
	///<summary>Offset for snap point on the surface of an existing object in the direction of the surface normal. Requires grid snapping to be disabled in viewport, and Snap to Surfaces and Enable Snapping to be true.</summary>
	public float SnapToSurfacesOffset;
}
