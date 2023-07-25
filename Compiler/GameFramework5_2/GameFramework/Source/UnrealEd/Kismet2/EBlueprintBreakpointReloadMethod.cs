#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Kismet2/KismetDebugUtilities.h")]
///<summary>Indicates how to restore breakpoints when a Blueprint asset is reloaded.</summary>
public enum EBlueprintBreakpointReloadMethod {
	RestoreAll=0,
	RestoreAllAndDisable=1,
	DiscardAll=2,
}
