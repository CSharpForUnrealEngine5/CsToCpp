namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/SimpleConstructionScript.h")]
public partial class USimpleConstructionScript : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Root nodes of the construction script</summary>
	public TArray<USCS_Node> RootNodes;
	///<summary>All nodes that exist in the hierarchy of this SimpleConstructionScript</summary>
	public TArray<USCS_Node> AllNodes;
	///<summary>Default scene root node; used when no other nodes are available to use as the root</summary>
	public USCS_Node DefaultSceneRootNode;
	///<summary>(DEPRECATED) Root node of the construction script</summary>
	public USCS_Node RootNode_DEPRECATED;
	///<summary>(DEPRECATED) Actor Component based nodes are stored here.  They cannot be in the tree hierarchy</summary>
	public TArray<USCS_Node> ActorComponentNodes_DEPRECATED;
}
