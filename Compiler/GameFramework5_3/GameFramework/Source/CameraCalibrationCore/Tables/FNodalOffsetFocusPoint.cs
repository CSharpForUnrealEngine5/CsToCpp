namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Focus point for nodal offset curves</summary>
[CppInclude("Tables/NodalOffsetTable.h")]
public partial struct FNodalOffsetFocusPoint {
	public float Focus;
	public FRichCurve LocationOffset;
	public FRichCurve RotationOffset;
}
