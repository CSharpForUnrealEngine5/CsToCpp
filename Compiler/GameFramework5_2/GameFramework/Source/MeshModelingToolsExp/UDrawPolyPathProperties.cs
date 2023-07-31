#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DrawPolyPathTool.h")]
public partial class UDrawPolyPathProperties : UInteractiveToolPropertySet {
	///<summary>How the drawn path width gets set</summary>
	public EDrawPolyPathWidthMode WidthMode;
	///<summary>Width of the drawn path when using Fixed width mode; also shows the width in Interactive width mode</summary>
	public float Width;
	///<summary>Use arc segments instead of straight lines in corners</summary>
	public bool bRoundedCorners;
	///<summary>How the rounded corner radius gets set</summary>
	public EDrawPolyPathRadiusMode RadiusMode;
	///<summary>Radius of the corner arcs, as a fraction of path width. This is only available if Rounded Corners is enabled.</summary>
	public float CornerRadius;
	///<summary>Number of radial subdivisions for rounded corners</summary>
	public int RadialSlices;
	///<summary>If true, all quads on the path will belong to the same polygon. If false, each quad gets its own polygon.</summary>
	public bool bSinglePolyGroup;
	///<summary>If and how the drawn path gets extruded</summary>
	public EDrawPolyPathExtrudeMode ExtrudeMode;
	///<summary>Extrusion distance when using the Fixed extrude modes; also shows the distance in Interactive extrude modes</summary>
	public float ExtrudeHeight;
	///<summary>Height of the start of the ramp as a fraction of the Extrude Height property</summary>
	public float RampStartRatio;
}
