#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldConditionBase.h")]
///<summary>Base struct for all World Conditions.</summary>
public partial struct FWorldConditionBase {
// WorldConditionBase
	public bool bInvert;
	public EWorldConditionOperator Operator;
	public byte NextExpressionDepth;
}
