#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>helper struct for defining types of allowed blackboard entries</summary>
[CppInclude("BehaviorTree/BehaviorTreeTypes.h")]
public partial struct FBlackboardKeySelector {
	public TArray<UBlackboardKeyType> AllowedTypes;
	public string SelectedKeyName;
	public UClass SelectedKeyType;
	public int SelectedKeyID;
	public bool bNoneIsAllowedValue;
}
