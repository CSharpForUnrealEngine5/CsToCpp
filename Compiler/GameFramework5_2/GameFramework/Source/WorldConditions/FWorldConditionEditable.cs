#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldConditionQuery.h")]
///<summary>Struct used to store a world condition in editor. Used internally.</summary>
public partial struct FWorldConditionEditable {
// WorldConditionEditable
	public byte ExpressionDepth;
	public EWorldConditionOperator Operator;
	public bool bInvert;
	public FInstancedStruct Condition;
}
