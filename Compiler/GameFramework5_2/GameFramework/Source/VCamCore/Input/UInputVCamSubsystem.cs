namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Handles all input for UVCamComponent.</summary>
[CppInclude("Input/InputVCamSubsystem.h")]
public partial class UInputVCamSubsystem : UVCamSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>SetShouldConsumeGamepadInput</summary>
	public void SetShouldConsumeGamepadInput(EVCamGamepadInputMode GamepadInputMode) {}
	///<summary>PlayerInput</summary>
	public UVCamPlayerInput PlayerInput;
	///<summary>Internal. This is the current stack of InputComponents that is being processed by the PlayerInput.</summary>
	public TArray<TWeakObjectPtr<UInputComponent>> CurrentInputStack;
}
