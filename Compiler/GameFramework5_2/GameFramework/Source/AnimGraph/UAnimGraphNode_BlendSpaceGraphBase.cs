#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimGraphNode_BlendSpaceGraphBase.h")]
public partial class UAnimGraphNode_BlendSpaceGraphBase : UAnimGraphNode_Base {
	public static UClass StaticClass() {return default;}
	///<summary>Internal blendspace</summary>
	public UBlendSpace BlendSpace;
	///<summary>Blendspace class, for template nodes</summary>
	public UClass BlendSpaceClass;
	///<summary>Dummy blendspace graph (used for navigation only)</summary>
	public UBlendSpaceGraph BlendSpaceGraph;
	///<summary>Linked animation graphs for sample points</summary>
	public TArray<UEdGraph> Graphs;
}
