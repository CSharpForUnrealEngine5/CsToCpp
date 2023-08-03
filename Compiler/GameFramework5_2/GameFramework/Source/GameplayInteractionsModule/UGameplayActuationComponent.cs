#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Component holding current actuation state, and functionality to create transitions between GameplayTasks.</summary>
[CppInclude("GameplayActuationComponent.h")]
public partial class UGameplayActuationComponent : UActorComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Current actuation state</summary>
	public FInstancedStruct ActuationState;
	///<summary>Transition descriptors</summary>
	public TArray<FInstancedStruct> Transitions;
	///<summary>If true, allow transition tasks.</summary>
	public bool bEnableTransitions;
}
