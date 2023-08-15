namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>helper struct for defining types of allowed blackboard entries</summary>
[CppInclude("BehaviorTree/BehaviorTreeTypes.h")]
public partial struct FBlackboardKeySelector {
	public TArray<UBlackboardKeyType> AllowedTypes;
	public FName SelectedKeyName;
	public UClass SelectedKeyType;
	public int SelectedKeyID;
	public bool bNoneIsAllowedValue;
}
