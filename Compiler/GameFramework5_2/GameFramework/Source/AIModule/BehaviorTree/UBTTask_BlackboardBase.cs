namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BehaviorTree/Tasks/BTTask_BlackboardBase.h")]
public partial class UBTTask_BlackboardBase : UBTTaskNode {
	public static UClass StaticClass() {return default;}
	///<summary>blackboard key selector</summary>
	public FBlackboardKeySelector BlackboardKey;
}
