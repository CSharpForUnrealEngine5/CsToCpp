namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Class that holds preset data for the automation window</summary>
[CppInclude("AutomationPresetManager.h")]
public partial struct FAutomationTestPreset {
	public FName Id;
	public FText Name;
	public TArray<string> EnabledTests;
}
