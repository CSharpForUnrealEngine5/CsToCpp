namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Transform incoming UV texture coordinates from one 2D frame of reference to another.</summary>
[CppInclude("MaterialX/MaterialExpressions/MaterialExpressionPlace2D.h")]
public partial class UMaterialExpressionMaterialXPlace2D : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>Defaults to &#39;ConstCoordinate&#39; if not specified</summary>
	public FExpressionInput Coordinates;
	///<summary>The pivot coordinate for scale and rotate: this is subtracted from u,v before</summary>
	public FExpressionInput Pivot;
	///<summary>Divide the u,v coord (after subtracting pivot ) by this, so a scale (2,2)</summary>
	public FExpressionInput Scale;
	///<summary>Subtract this amount from the scaled/rotated/“pivot added back” UV</summary>
	public FExpressionInput Offset;
	///<summary>Defaults to &#39;ConstRotationAngle&#39; if not specified</summary>
	public FExpressionInput RotationAngle;
	///<summary>only used if RotationAngle is not hooked up</summary>
	public float ConstRotationAngle;
	///<summary>only used if Coordinates is not hooked up</summary>
	public byte ConstCoordinate;
}
