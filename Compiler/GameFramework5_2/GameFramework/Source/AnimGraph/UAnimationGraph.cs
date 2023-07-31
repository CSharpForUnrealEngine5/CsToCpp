#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimationGraph.h")]
public partial class UAnimationGraph : UEdGraph {
	///<summary>Blending options for animation graphs in Linked Animation Blueprints.</summary>
	public FAnimGraphBlendOptions BlendOptions;
	///<summary>Returns contained graph nodes of the specified (or child) class</summary>
	public  void GetGraphNodesOfClass(UClass NodeClass,TArray<UAnimGraphNode_Base> GraphNodes,bool bIncludeChildClasses/*=true*/) {}
}
