namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Per world input subsystem that allows you to bind input delegates to actors without an owning Player Controller.</summary>
[CppInclude("EnhancedInputSubsystems.h")]
public partial class UEnhancedInputWorldSubsystem : UWorldSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>Adds this Actor&#39;s input component onto the stack to be processed by this subsystem&#39;s tick function</summary>
	public void AddActorInputComponent(AActor Actor) {}
	///<summary>Removes this Actor&#39;s input component from the stack to be processed by this subsystem&#39;s tick function</summary>
	public bool RemoveActorInputComponent(AActor Actor) { return default; }
	///<summary>The player input that is processing the input within this subsystem</summary>
	public UEnhancedPlayerInput PlayerInput;
	///<summary>Internal. This is the current stack of InputComponents that is being processed by the PlayerInput.</summary>
	public TArray<TWeakObjectPtr<UInputComponent>> CurrentInputStack;
}
