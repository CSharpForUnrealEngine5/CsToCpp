#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BehaviorTree/Decorators/BTDecorator_Blackboard.h")]
///<summary>Blackboard decorator node.</summary>
public partial class UBTDecorator_Blackboard : UBTDecorator_BlackboardBase {
// BTDecorator_Blackboard
	public int IntValue;
	public float FloatValue;
	public string StringValue;
	public string CachedDescription;
	public byte OperationType;
	public EBTBlackboardRestart NotifyObserver;
	public EBasicKeyOperation BasicOperation;
	public EArithmeticKeyOperation ArithmeticOperation;
	public ETextKeyOperation TextOperation;
}
