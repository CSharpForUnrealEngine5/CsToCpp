#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Input/InputVCamSubsystem.h")]
///<summary>Handles all input for UVCamComponent.</summary>
public partial class UInputVCamSubsystem : UVCamSubsystem {
// InputVCamSubsystem
	public void SetShouldConsumeGamepadInput(EVCamGamepadInputMode GamepadInputMode) {}
	public UVCamPlayerInput PlayerInput;
	public TArray<TWeakObjectPtr<UInputComponent>> CurrentInputStack;
}
