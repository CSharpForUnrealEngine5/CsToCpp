#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Class that holds preset data for the automation window</summary>
[CppInclude("AutomationPresetManager.h")]
public partial struct FAutomationTestPreset {
	public string Id;
	public string Name;
	public TArray<string> EnabledTests;
}
