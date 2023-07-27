#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimStateNode.h")]
public partial class UAnimStateNode : UAnimStateNodeBase {
// AnimStateNode
	public UEdGraph BoundGraph;
	public EAnimStateType StateType;
	public FAnimNotifyEvent StateEntered;
	public FAnimNotifyEvent StateLeft;
	public FAnimNotifyEvent StateFullyBlended;
	public bool bAlwaysResetOnEntry;
}
