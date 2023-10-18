namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Handles all input for UVCamComponent.</summary>
[CppInclude("Input/InputVCamSubsystem.h")]
public partial class UInputVCamSubsystem : UVCamSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>PlayerInput</summary>
	public UVCamPlayerInput PlayerInput;
	///<summary>Internal. This is the current stack of InputComponents that is being processed by the PlayerInput.</summary>
	public TArray<TWeakObjectPtr<UInputComponent>> CurrentInputStack;
	///<summary>The user settings for this subsystem used to store each user&#39;s input related settings</summary>
	public UEnhancedInputUserSettings UserSettings;
}
