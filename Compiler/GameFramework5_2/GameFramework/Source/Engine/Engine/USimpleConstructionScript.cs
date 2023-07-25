#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/SimpleConstructionScript.h")]
public partial class USimpleConstructionScript : UObject {
// SimpleConstructionScript
	public TArray<USCS_Node> RootNodes;
	public TArray<USCS_Node> AllNodes;
	public USCS_Node DefaultSceneRootNode;
	public USCS_Node RootNode_DEPRECATED;
	public TArray<USCS_Node> ActorComponentNodes_DEPRECATED;
}
