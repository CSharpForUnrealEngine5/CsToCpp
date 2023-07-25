#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DrawPolygonTool.h")]
public partial class UDrawPolygonToolSnapProperties : UInteractiveToolPropertySet {
// DrawPolygonToolSnapProperties
	public bool bEnableSnapping;
	public bool bSnapToWorldGrid;
	public bool bSnapToVertices;
	public bool bSnapToEdges;
	public bool bSnapToAxes;
	public bool bSnapToLengths;
	public bool bSnapToSurfaces;
	public float SnapToSurfacesOffset;
}
