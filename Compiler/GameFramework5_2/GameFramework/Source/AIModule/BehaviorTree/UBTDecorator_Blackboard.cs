#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Blackboard decorator node.</summary>
[CppInclude("BehaviorTree/Decorators/BTDecorator_Blackboard.h")]
public partial class UBTDecorator_Blackboard : UBTDecorator_BlackboardBase {
	///<summary>value for arithmetic operations</summary>
	public int IntValue;
	///<summary>value for arithmetic operations</summary>
	public float FloatValue;
	///<summary>value for string operations</summary>
	public string StringValue;
	///<summary>cached description</summary>
	public string CachedDescription;
	///<summary>operation type</summary>
	public byte OperationType;
	///<summary>when observer can try to request abort?</summary>
	public EBTBlackboardRestart NotifyObserver;
	///<summary>BasicOperation</summary>
	public EBasicKeyOperation BasicOperation;
	///<summary>ArithmeticOperation</summary>
	public EArithmeticKeyOperation ArithmeticOperation;
	///<summary>TextOperation</summary>
	public ETextKeyOperation TextOperation;
}
