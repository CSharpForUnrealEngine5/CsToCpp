namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Time Limit decorator node.</summary>
[CppInclude("BehaviorTree/Decorators/BTDecorator_TimeLimit.h")]
public partial class UBTDecorator_TimeLimit : UBTDecorator {
	public static UClass StaticClass() {return default;}
	///<summary>max allowed time for execution of underlying node</summary>
	public float TimeLimit;
}
