namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>NOTE: this behavior works only for AIControlled pawns</summary>
[CppInclude("AI/GameplayBehavior_BehaviorTree.h")]
public partial class UGameplayBehavior_BehaviorTree : UGameplayBehavior {
	public static UClass StaticClass() {return default;}
	///<summary>PreviousBT</summary>
	public UBehaviorTree PreviousBT;
	///<summary>AIController</summary>
	public AAIController AIController;
	///<summary>Indicates if BehaviorTree should run only once or in loop.</summary>
	public bool bSingleRun;
}
