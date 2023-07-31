#pragma warning disable CS8618,CS8603,CS1587,CS1591
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
