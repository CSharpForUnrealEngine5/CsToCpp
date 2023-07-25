#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BehaviorTree/BlackboardData.h")]
///<summary>blackboard entry definition</summary>
public partial struct FBlackboardEntry {
// BlackboardEntry
	public string EntryName;
	public string EntryDescription;
	public string EntryCategory;
	public UBlackboardKeyType KeyType;
	public bool bInstanceSynced;
}
