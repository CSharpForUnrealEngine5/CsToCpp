namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A material expression that computes a left-to-right bilinear value ramp.</summary>
[CppInclude("MaterialX/MaterialExpressions/MaterialExpressionRampLeftRight.h")]
public partial class UMaterialExpressionMaterialXRampLeftRight : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>Defaults to &#39;ConstCoordinate&#39; if not specified</summary>
	public FExpressionInput Coordinates;
	///<summary>A</summary>
	public FExpressionInput A;
	///<summary>B</summary>
	public FExpressionInput B;
	///<summary>only used if Coordinates is not hooked up</summary>
	public byte ConstCoordinate;
}
