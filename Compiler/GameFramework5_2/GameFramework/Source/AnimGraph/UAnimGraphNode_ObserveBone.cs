#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This allows you to observe the state of a bone at a particular point in the graph, showing it in any space and optionally relative to the reference pose</summary>
[CppInclude("AnimGraphNode_ObserveBone.h")]
public partial class UAnimGraphNode_ObserveBone : UAnimGraphNode_SkeletalControlBase {
	public static UClass StaticClass() {return default;}
	///<summary>Node</summary>
	public FAnimNode_ObserveBone Node;
}
