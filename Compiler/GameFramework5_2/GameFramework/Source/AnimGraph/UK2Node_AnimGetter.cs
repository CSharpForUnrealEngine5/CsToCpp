namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("K2Node_AnimGetter.h")]
public partial class UK2Node_AnimGetter : UK2Node_CallFunction {
	public static UClass StaticClass() {return default;}
	///<summary>The node that is required for the getter</summary>
	public UAnimGraphNode_Base SourceNode;
	///<summary>UAnimStateNode doesn&#39;t use the same hierarchy so we need to have a seperate property here to handle</summary>
	public UAnimStateNodeBase SourceStateNode;
	///<summary>The UAnimInstance derived class that implements the getter we are running</summary>
	public UClass GetterClass;
	///<summary>The anim blueprint that generated this getter</summary>
	public UAnimBlueprint SourceAnimBlueprint;
	///<summary>Cached node title</summary>
	public FText CachedTitle;
	///<summary>List of valid contexts for the node</summary>
	public TArray<string> Contexts;
}
