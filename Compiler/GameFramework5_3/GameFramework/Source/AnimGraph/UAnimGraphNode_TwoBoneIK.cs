namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimGraphNode_TwoBoneIK.h")]
public partial class UAnimGraphNode_TwoBoneIK : UAnimGraphNode_SkeletalControlBase {
	public static UClass StaticClass() {return default;}
	///<summary>Node</summary>
	public FAnimNode_TwoBoneIK Node;
	///<summary>Enable drawing of the debug information of the node</summary>
	public bool bEnableDebugDraw;
}
