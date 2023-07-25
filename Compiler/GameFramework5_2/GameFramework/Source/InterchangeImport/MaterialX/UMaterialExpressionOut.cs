#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MaterialX/MaterialExpressionOut.h")]
///<summary>Merge nodes take two 4-channel (color4) inputs and use the built-in alpha channel(s) to control the</summary>
public partial class UMaterialExpressionOut : UMaterialExpression {
// MaterialExpressionOut
	public FExpressionInput A;
	public FExpressionInput B;
	public FExpressionInput Alpha;
	public float ConstAlpha;
}
