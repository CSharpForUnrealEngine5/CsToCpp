#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MaterialGraph/MaterialGraph.h")]
public partial class UMaterialGraph : UEdGraph {
	public static UClass StaticClass() {return default;}
	///<summary>Material this Graph represents</summary>
	public UMaterial Material;
	///<summary>Material Function this Graph represents (NULL for Materials)</summary>
	public UMaterialFunction MaterialFunction;
	///<summary>Root node representing Material inputs (NULL for Material Functions)</summary>
	public UMaterialGraphNode_Root RootNode;
	///<summary>Expression this subgraph represents (NULL if not subgraph, Material [Function] still populated)</summary>
	public UMaterialExpression SubgraphExpression;
	///<summary>The name of the material that we are editing</summary>
	public string OriginalMaterialFullName;
}
