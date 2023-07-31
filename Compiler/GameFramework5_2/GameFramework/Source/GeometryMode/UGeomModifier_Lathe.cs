#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeomModifier_Lathe.h")]
public partial class UGeomModifier_Lathe : UGeomModifier_Edit {
	///<summary>TotalSegments</summary>
	public int TotalSegments;
	///<summary>Segments</summary>
	public int Segments;
	///<summary>AlignToSide</summary>
	public bool AlignToSide;
	///<summary>The axis of rotation to use when creating the brush.  This is automatically determined from the current ortho viewport.</summary>
	public EAxis Axis;
}
