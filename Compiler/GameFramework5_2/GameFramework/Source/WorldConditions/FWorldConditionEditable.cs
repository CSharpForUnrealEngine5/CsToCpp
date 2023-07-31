#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct used to store a world condition in editor. Used internally.</summary>
[CppInclude("WorldConditionQuery.h")]
public partial struct FWorldConditionEditable {
	public byte ExpressionDepth;
	public EWorldConditionOperator Operator;
	public bool bInvert;
	public FInstancedStruct Condition;
}
