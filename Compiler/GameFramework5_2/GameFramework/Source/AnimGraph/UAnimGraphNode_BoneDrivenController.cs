#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This is the &#39;source version&#39; of a bone driven controller, which maps part of the state from one bone to another (e.g., 2 * source.x -&gt; target.z)</summary>
[CppInclude("AnimGraphNode_BoneDrivenController.h")]
public partial class UAnimGraphNode_BoneDrivenController : UAnimGraphNode_SkeletalControlBase {
	public static UClass StaticClass() {return default;}
	///<summary>Node</summary>
	public FAnimNode_BoneDrivenController Node;
}
