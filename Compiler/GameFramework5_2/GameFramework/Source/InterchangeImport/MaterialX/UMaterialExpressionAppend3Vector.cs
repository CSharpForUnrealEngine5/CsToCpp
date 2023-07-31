#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A material expression that allows combining 3 channels together to create a vector with more channel than the original</summary>
[CppInclude("MaterialX/MaterialExpressionAppend3Vector.h")]
public partial class UMaterialExpressionAppend3Vector : UMaterialExpression {
	///<summary>A</summary>
	public FExpressionInput A;
	///<summary>B</summary>
	public FExpressionInput B;
	///<summary>C</summary>
	public FExpressionInput C;
}
