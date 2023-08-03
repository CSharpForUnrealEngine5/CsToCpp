#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for managing gameplay tasks</summary>
[CppInclude("BehaviorTree/Tasks/BTTask_GameplayTaskBase.h")]
public partial class UBTTask_GameplayTaskBase : UBTTaskNode {
	public static UClass StaticClass() {return default;}
	///<summary>if set, behavior tree task will wait until gameplay tasks finishes</summary>
	public bool bWaitForGameplayTask;
}
