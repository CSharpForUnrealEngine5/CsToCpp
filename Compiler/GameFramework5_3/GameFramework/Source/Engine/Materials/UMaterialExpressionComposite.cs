namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Composite (subgraph) expression. Exists purely for organzational purposes.</summary>
[CppInclude("Materials/MaterialExpressionComposite.h")]
public partial class UMaterialExpressionComposite : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>SubgraphName</summary>
	public string SubgraphName;
	///<summary>InputExpressions</summary>
	public UMaterialExpressionPinBase InputExpressions;
	///<summary>OutputExpressions</summary>
	public UMaterialExpressionPinBase OutputExpressions;
}
