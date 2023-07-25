#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MaterialX/MaterialExpressionIn.h")]
///<summary>Merge nodes take two 4-channel (color4) inputs and use the built-in alpha channel(s) to control the</summary>
public partial class UMaterialExpressionIn : UMaterialExpression {
// MaterialExpressionIn
	public FExpressionInput A;
	public FExpressionInput B;
	public FExpressionInput Alpha;
	public float ConstAlpha;
}
