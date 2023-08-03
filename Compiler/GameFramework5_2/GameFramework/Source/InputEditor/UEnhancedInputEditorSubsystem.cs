#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The Enhanced Input Editor Subsystem can be used to process input outside of PIE within the editor.</summary>
[CppInclude("EnhancedInputEditorSubsystem.h")]
public partial class UEnhancedInputEditorSubsystem : UEditorSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>Pushes this input component onto the stack to be processed by this subsystem&#39;s tick function</summary>
	public  void PushInputComponent(UInputComponent InInputComponent) {}
	///<summary>Removes this input component onto the stack to be processed by this subsystem&#39;s tick function</summary>
	public  bool PopInputComponent(UInputComponent InInputComponent) { return default; }
	///<summary>Start the consumption of input messages in this subsystem. This is required to have any Input Action delegates be fired.</summary>
	public  void StartConsumingInput() {}
	///<summary>Tells this subsystem to stop ticking and consuming any input. This will stop any Input Action Delegates from being called.</summary>
	public  void StopConsumingInput() {}
	///<summary>Returns true if this subsystem is currently consuming input</summary>
	public  bool IsConsumingInput() { return default; }
	///<summary>The player input that is processing the input within this subsystem</summary>
	public UEnhancedPlayerInput PlayerInput;
	///<summary>Internal. This is the current stack of InputComponents that is being processed by the PlayerInput.</summary>
	public TArray<TWeakObjectPtr<UInputComponent>> CurrentInputStack;
}
