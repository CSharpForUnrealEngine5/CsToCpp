namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This is the &#39;source version&#39; of a bone driven controller, which maps part of the state from one bone to another (e.g., 2 * source.x -&gt; target.z)</summary>
[CppInclude("AnimGraphNode_TwistCorrectiveNode.h")]
public partial class UAnimGraphNode_TwistCorrectiveNode : UAnimGraphNode_SkeletalControlBase {
	public static UClass StaticClass() {return default;}
	///<summary>Node</summary>
	public FAnimNode_TwistCorrectiveNode Node;
}
