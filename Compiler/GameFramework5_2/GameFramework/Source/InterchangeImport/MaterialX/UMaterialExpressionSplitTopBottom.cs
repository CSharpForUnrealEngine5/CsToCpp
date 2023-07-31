#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A material expression that computes a top-bottom split matte, split at a specified v value.</summary>
[CppInclude("MaterialX/MaterialExpressionSplitTopBottom.h")]
public partial class UMaterialExpressionSplitTopBottom : UMaterialExpression {
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
