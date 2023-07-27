#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimationGraph.h")]
public partial class UAnimationGraph : UEdGraph {
// AnimationGraph
	public FAnimGraphBlendOptions BlendOptions;
	public  void GetGraphNodesOfClass(UClass NodeClass,TArray<UAnimGraphNode_Base> GraphNodes,bool bIncludeChildClasses/*=true*/) {}
}
