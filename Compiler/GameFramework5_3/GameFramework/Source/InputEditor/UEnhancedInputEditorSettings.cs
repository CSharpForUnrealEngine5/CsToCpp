namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A collection of useful individual user settings when using the EnhancedInputEditorSubsystem.</summary>
[CppInclude("EnhancedInputEditorSettings.h")]
public partial class UEnhancedInputEditorSettings : UDeveloperSettingsBackedByCVars {
	public static UClass StaticClass() {return default;}
	///<summary>If true then the Enhanced Input Editor subsystem will log all input that is being processed by it (keypresses, analog values, etc)</summary>
	public bool bLogAllInput;
	///<summary>If true, then the UEnhancedInputEditorSubsystem will be started when it is initalized</summary>
	public bool bAutomaticallyStartConsumingInput;
	///<summary>A bitmask of what event pins are visible when you place an Input Action event node in blueprints.</summary>
	public byte VisibleEventPinsByDefault;
}
