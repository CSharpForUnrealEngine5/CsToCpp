#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Blueprint Editor settings that are different for each</summary>
[CppInclude("BlueprintEditorSettings.h")]
public partial struct FPerBlueprintSettings {
	public TArray<FBlueprintBreakpoint> Breakpoints;
	public TArray<FBlueprintWatchedPin> WatchedPins;
}
