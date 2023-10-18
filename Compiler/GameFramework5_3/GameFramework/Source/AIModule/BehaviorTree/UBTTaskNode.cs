namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Task are leaf nodes of behavior tree, which perform actual actions</summary>
[CppInclude("BehaviorTree/BTTaskNode.h")]
public partial class UBTTaskNode : UBTNode {
	public static UClass StaticClass() {return default;}
	///<summary>service nodes</summary>
	public TArray<UBTService> Services;
	///<summary>if set, task search will be discarded when this task is selected to execute but is already running</summary>
	public bool bIgnoreRestartSelf;
}
