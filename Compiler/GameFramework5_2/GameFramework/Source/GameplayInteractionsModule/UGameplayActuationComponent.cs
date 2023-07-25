#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayActuationComponent.h")]
///<summary>Component holding current actuation state, and functionality to create transitions between GameplayTasks.</summary>
public partial class UGameplayActuationComponent : UActorComponent {
// GameplayActuationComponent
	public FInstancedStruct ActuationState;
	public TArray<FInstancedStruct> Transitions;
	public bool bEnableTransitions;
}
