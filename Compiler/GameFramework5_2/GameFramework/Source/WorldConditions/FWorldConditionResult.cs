namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Result of a world condition evaluation.</summary>
[CppInclude("WorldConditionTypes.h")]
public partial struct FWorldConditionResult {
	public EWorldConditionResultValue Value;
	public bool bCanBeCached;
}
