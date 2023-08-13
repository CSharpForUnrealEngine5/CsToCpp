namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BehaviorTree/Services/BTService_BlackboardBase.h")]
public partial class UBTService_BlackboardBase : UBTService {
	public static UClass StaticClass() {return default;}
	///<summary>blackboard key selector</summary>
	public FBlackboardKeySelector BlackboardKey;
}
