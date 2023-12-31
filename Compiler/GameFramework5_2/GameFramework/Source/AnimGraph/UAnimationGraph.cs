namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimationGraph.h")]
public partial class UAnimationGraph : UEdGraph {
	public static UClass StaticClass() {return default;}
	///<summary>Blending options for animation graphs in Linked Animation Blueprints.</summary>
	public FAnimGraphBlendOptions BlendOptions;
	///<summary>Returns contained graph nodes of the specified (or child) class</summary>
	public void GetGraphNodesOfClass(UClass NodeClass,TArray<UAnimGraphNode_Base> GraphNodes,bool bIncludeChildClasses/*=true*/) {}
}
