#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Handles all input for UVCamComponent.</summary>
[CppInclude("Input/InputVCamSubsystem.h")]
public partial class UInputVCamSubsystem : UVCamSubsystem {
	///<summary>SetShouldConsumeGamepadInput</summary>
	public  void SetShouldConsumeGamepadInput(EVCamGamepadInputMode GamepadInputMode) {}
	///<summary>PlayerInput</summary>
	public UVCamPlayerInput PlayerInput;
	///<summary>Internal. This is the current stack of InputComponents that is being processed by the PlayerInput.</summary>
	public TArray<TWeakObjectPtr<UInputComponent>> CurrentInputStack;
}
