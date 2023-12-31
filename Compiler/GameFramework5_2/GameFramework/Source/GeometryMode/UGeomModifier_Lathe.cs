namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeomModifier_Lathe.h")]
public partial class UGeomModifier_Lathe : UGeomModifier_Edit {
	public static UClass StaticClass() {return default;}
	///<summary>TotalSegments</summary>
	public int TotalSegments;
	///<summary>Segments</summary>
	public int Segments;
	///<summary>AlignToSide</summary>
	public bool AlignToSide;
	///<summary>The axis of rotation to use when creating the brush.  This is automatically determined from the current ortho viewport.</summary>
	public EAxis Axis;
}
