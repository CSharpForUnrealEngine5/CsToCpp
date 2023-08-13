namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>blackboard entry definition</summary>
[CppInclude("BehaviorTree/BlackboardData.h")]
public partial struct FBlackboardEntry {
	public string EntryName;
	public string EntryDescription;
	public string EntryCategory;
	public UBlackboardKeyType KeyType;
	public bool bInstanceSynced;
}
