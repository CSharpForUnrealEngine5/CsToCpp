#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EnhancedInputSubsystems.h")]
///<summary>Per world input subsystem that allows you to bind input delegates to actors without an owning Player Controller.</summary>
public partial class UEnhancedInputWorldSubsystem : UWorldSubsystem {
// EnhancedInputWorldSubsystem
	public void AddActorInputComponent(UObject Actor) {}
	public bool RemoveActorInputComponent(UObject Actor) { return default; }
	public UEnhancedPlayerInput PlayerInput;
	public TArray<TWeakObjectPtr<UInputComponent>> CurrentInputStack;
}
