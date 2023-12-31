namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Move Directly Toward task node.</summary>
[CppInclude("BehaviorTree/Tasks/BTTask_MoveDirectlyToward.h")]
public partial class UBTTask_MoveDirectlyToward : UBTTask_MoveTo {
	public static UClass StaticClass() {return default;}
	///<summary>bDisablePathUpdateOnGoalLocationChange</summary>
	public bool bDisablePathUpdateOnGoalLocationChange;
	///<summary>bProjectVectorGoalToNavigation</summary>
	public bool bProjectVectorGoalToNavigation;
	///<summary>bUpdatedDeprecatedProperties</summary>
	public bool bUpdatedDeprecatedProperties;
}
