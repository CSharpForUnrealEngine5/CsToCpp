#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MaterialGraph/MaterialGraph.h")]
public partial class UMaterialGraph : UEdGraph {
// MaterialGraph
	public UMaterial Material;
	public UMaterialFunction MaterialFunction;
	public UMaterialGraphNode_Root RootNode;
	public UMaterialExpression SubgraphExpression;
	public string OriginalMaterialFullName;
}
