namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Editor node for CCDIK IK skeletal controller</summary>
[CppInclude("AnimGraphNode_CCDIK.h")]
public partial class UAnimGraphNode_CCDIK : UAnimGraphNode_SkeletalControlBase {
	public static UClass StaticClass() {return default;}
	///<summary>Node</summary>
	public FAnimNode_CCDIK Node;
}
