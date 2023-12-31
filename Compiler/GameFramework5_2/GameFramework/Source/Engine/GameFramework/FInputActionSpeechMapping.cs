namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Defines a mapping between an action and speech recognition</summary>
[CppInclude("GameFramework/PlayerInput.h")]
public partial struct FInputActionSpeechMapping {
	public FName ActionName;
	public FName SpeechKeyword;
}
