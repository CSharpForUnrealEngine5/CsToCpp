#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base struct for all conditions.</summary>
[CppInclude("StateTreeConditionBase.h")]
public partial struct FStateTreeConditionBase {
	public EStateTreeConditionOperand Operand;
	public short DeltaIndent;
}
