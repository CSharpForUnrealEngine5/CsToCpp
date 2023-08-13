namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimStateNode.h")]
public partial class UAnimStateNode : UAnimStateNodeBase {
	public static UClass StaticClass() {return default;}
	///<summary>The animation graph for this state</summary>
	public UEdGraph BoundGraph;
	///<summary>The type of the contents of this state</summary>
	public EAnimStateType StateType;
	///<summary>StateEntered</summary>
	public FAnimNotifyEvent StateEntered;
	///<summary>StateLeft</summary>
	public FAnimNotifyEvent StateLeft;
	///<summary>StateFullyBlended</summary>
	public FAnimNotifyEvent StateFullyBlended;
	///<summary>Whether or not this state will ALWAYS reset it&#39;s state on reentry, regardless of remaining weight</summary>
	public bool bAlwaysResetOnEntry;
}
