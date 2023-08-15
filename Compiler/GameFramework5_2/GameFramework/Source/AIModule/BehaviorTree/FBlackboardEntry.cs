namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>blackboard entry definition</summary>
[CppInclude("BehaviorTree/BlackboardData.h")]
public partial struct FBlackboardEntry {
	public FName EntryName;
	public string EntryDescription;
	public FName EntryCategory;
	public UBlackboardKeyType KeyType;
	public bool bInstanceSynced;
}
