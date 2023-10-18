namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A material expression that computes a left-right split matte, split at a specified u value.</summary>
[CppInclude("MaterialX/MaterialExpressions/MaterialExpressionSplitLeftRight.h")]
public partial class UMaterialExpressionMaterialXSplitLeftRight : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>Defaults to &#39;ConstCoordinate&#39; if not specified</summary>
	public FExpressionInput Coordinates;
	///<summary>A</summary>
	public FExpressionInput A;
	///<summary>B</summary>
	public FExpressionInput B;
	///<summary>Defaults to &#39;ConstCenter&#39; if not specified</summary>
	public FExpressionInput Center;
	///<summary>only used if A is not hooked up</summary>
	public float ConstCenter;
	///<summary>only used if Coordinates is not hooked up</summary>
	public byte ConstCoordinate;
}
