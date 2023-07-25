#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AI/GameplayBehavior_BehaviorTree.h")]
///<summary>NOTE: this behavior works only for AIControlled pawns</summary>
public partial class UGameplayBehavior_BehaviorTree : UGameplayBehavior {
// GameplayBehavior_BehaviorTree
	public UBehaviorTree PreviousBT;
	public AAIController AIController;
	public bool bSingleRun;
}
