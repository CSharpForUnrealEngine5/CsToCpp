namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Run time queryable action instance</summary>
[CppInclude("InputAction.h")]
public partial struct FInputActionInstance {
	public UInputAction SourceAction;
	public ETriggerEvent TriggerEvent;
	public float LastTriggeredWorldTime;
	public TArray<UInputTrigger> Triggers;
	public TArray<UInputModifier> Modifiers;
	public float ElapsedProcessedTime;
	public float ElapsedTriggeredTime;
}
