#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BehaviorTree/BlackboardData.h")]
public partial class UBlackboardData : UDataAsset {
// BlackboardData
	public UBlackboardData Parent;
	public TArray<FBlackboardEntry> ParentKeys;
	public TArray<FBlackboardEntry> Keys;
	public bool bHasSynchronizedKeys;
}
