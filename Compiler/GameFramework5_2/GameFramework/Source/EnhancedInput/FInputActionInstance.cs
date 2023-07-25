#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InputAction.h")]
///<summary>Run time queryable action instance</summary>
public partial struct FInputActionInstance {
// InputActionInstance
	public UInputAction SourceAction;
	public ETriggerEvent TriggerEvent;
	public float LastTriggeredWorldTime;
	public TArray<UInputTrigger> Triggers;
	public TArray<UInputModifier> Modifiers;
	public float ElapsedProcessedTime;
	public float ElapsedTriggeredTime;
}
