#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MaterialX/MaterialExpressionPlus.h")]
///<summary>Blend nodes take two 1-4 channel inputs and apply the same operator to all channels.</summary>
public partial class UMaterialExpressionPlus : UMaterialExpression {
// MaterialExpressionPlus
	public FExpressionInput A;
	public FExpressionInput B;
	public FExpressionInput Alpha;
	public float ConstAlpha;
}
