namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BehaviorTree/BlackboardData.h")]
public partial class UBlackboardData : UDataAsset {
	public static UClass StaticClass() {return default;}
	///<summary>parent blackboard (keys can be overridden)</summary>
	public UBlackboardData Parent;
	///<summary>all keys inherited from parent chain</summary>
	public TArray<FBlackboardEntry> ParentKeys;
	///<summary>blackboard keys</summary>
	public TArray<FBlackboardEntry> Keys;
	///<summary>bHasSynchronizedKeys</summary>
	public bool bHasSynchronizedKeys;
}
