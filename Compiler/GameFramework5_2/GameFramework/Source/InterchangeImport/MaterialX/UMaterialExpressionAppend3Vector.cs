#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MaterialX/MaterialExpressionAppend3Vector.h")]
///<summary>A material expression that allows combining 3 channels together to create a vector with more channel than the original</summary>
public partial class UMaterialExpressionAppend3Vector : UMaterialExpression {
// MaterialExpressionAppend3Vector
	public FExpressionInput A;
	public FExpressionInput B;
	public FExpressionInput C;
}
