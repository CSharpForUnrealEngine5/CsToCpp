namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Editor node for IKRig</summary>
[CppInclude("AnimGraphNode_IKRig.h")]
public partial class UAnimGraphNode_IKRig : UAnimGraphNode_CustomProperty {
	public static UClass StaticClass() {return default;}
	///<summary>Node</summary>
	public FAnimNode_IKRig Node;
}
