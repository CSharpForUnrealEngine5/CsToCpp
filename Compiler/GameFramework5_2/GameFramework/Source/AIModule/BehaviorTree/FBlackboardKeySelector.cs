#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BehaviorTree/BehaviorTreeTypes.h")]
///<summary>helper struct for defining types of allowed blackboard entries</summary>
public partial struct FBlackboardKeySelector {
// BlackboardKeySelector
	public TArray<UBlackboardKeyType> AllowedTypes;
	public string SelectedKeyName;
	public UClass SelectedKeyType;
	public int SelectedKeyID;
	public bool bNoneIsAllowedValue;
}
