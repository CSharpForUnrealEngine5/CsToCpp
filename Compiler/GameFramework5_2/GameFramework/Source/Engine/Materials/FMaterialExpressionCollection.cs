#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpression.h")]
public partial struct FMaterialExpressionCollection {
	public TArray<UMaterialExpression> Expressions;
	public TArray<UMaterialExpressionComment> EditorComments;
	public UMaterialExpressionExecBegin ExpressionExecBegin;
	public UMaterialExpressionExecEnd ExpressionExecEnd;
}
