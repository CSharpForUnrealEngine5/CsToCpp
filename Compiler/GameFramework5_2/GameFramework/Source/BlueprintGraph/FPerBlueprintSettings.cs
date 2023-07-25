#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BlueprintEditorSettings.h")]
///<summary>Blueprint Editor settings that are different for each</summary>
public partial struct FPerBlueprintSettings {
// PerBlueprintSettings
	public TArray<FBlueprintBreakpoint> Breakpoints;
	public TArray<FBlueprintWatchedPin> WatchedPins;
}
