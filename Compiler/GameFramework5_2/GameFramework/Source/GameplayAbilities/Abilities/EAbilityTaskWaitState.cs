#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/Tasks/AbilityTask.h")]
///<summary>Latent tasks are waiting on something. This is to differeniate waiting on the user to do something vs waiting on the game to do something.</summary>
public enum EAbilityTaskWaitState {
	WaitingOnGame=1,
	WaitingOnUser=2,
	WaitingOnAvatar=4,
}
