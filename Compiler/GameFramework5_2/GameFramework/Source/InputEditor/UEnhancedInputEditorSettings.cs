#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A collection of useful indivudal user settings when using the EnhancedInputEditorSubsystem.</summary>
[CppInclude("EnhancedInputEditorSettings.h")]
public partial class UEnhancedInputEditorSettings : UDeveloperSettingsBackedByCVars {
	///<summary>If true then the Enhanced Input Editor subsystem will log all input that is being processed by it (keypresses, analog values, etc)</summary>
	public bool bLogAllInput;
	///<summary>If true, then the UEnhancedInputEditorSubsystem will be started when it is initalized</summary>
	public bool bAutomaticallyStartConsumingInput;
}
