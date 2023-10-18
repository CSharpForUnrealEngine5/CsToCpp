namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A material expression that computes a 4-corner bilinear value ramp..</summary>
[CppInclude("MaterialX/MaterialExpressions/MaterialExpressionRamp4.h")]
public partial class UMaterialExpressionMaterialXRamp4 : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>Defaults to &#39;ConstCoordinate&#39; if not specified</summary>
	public FExpressionInput Coordinates;
	///<summary>The value at the top-left (U0V1) corner</summary>
	public FExpressionInput A;
	///<summary>The value at the top-right (U1V1) corner</summary>
	public FExpressionInput B;
	///<summary>The value at the bottom-left (U0V0) corner</summary>
	public FExpressionInput C;
	///<summary>The value at the bottom-right (U1V0) corner</summary>
	public FExpressionInput D;
	///<summary>only used if Coordinates is not hooked up</summary>
	public byte ConstCoordinate;
}
