#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MaterialX/MaterialExpressionAppend4Vector.h")]
///<summary>A material expression that allows combining 4 channels together to create a vector with more channel than the original</summary>
public partial class UMaterialExpressionAppend4Vector : UMaterialExpression {
// MaterialExpressionAppend4Vector
	public FExpressionInput A;
	public FExpressionInput B;
	public FExpressionInput C;
	public FExpressionInput D;
}
