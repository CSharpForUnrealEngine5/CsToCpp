namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Editor node for FABRIK IK skeletal controller</summary>
[CppInclude("AnimGraphNode_Fabrik.h")]
public partial class UAnimGraphNode_Fabrik : UAnimGraphNode_SkeletalControlBase {
	public static UClass StaticClass() {return default;}
	///<summary>Node</summary>
	public FAnimNode_Fabrik Node;
}
