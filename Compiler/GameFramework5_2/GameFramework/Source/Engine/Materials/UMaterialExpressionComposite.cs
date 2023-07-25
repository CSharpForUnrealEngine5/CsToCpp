#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionComposite.h")]
///<summary>Composite (subgraph) expression. Exists purely for organzational purposes.</summary>
public partial class UMaterialExpressionComposite : UMaterialExpression {
// MaterialExpressionComposite
	public string SubgraphName;
	public UMaterialExpressionPinBase InputExpressions;
	public UMaterialExpressionPinBase OutputExpressions;
}
