namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BehaviorTree/Decorators/BTDecorator_BlackboardBase.h")]
public partial class UBTDecorator_BlackboardBase : UBTDecorator {
	public static UClass StaticClass() {return default;}
	///<summary>blackboard key selector</summary>
	public FBlackboardKeySelector BlackboardKey;
}
