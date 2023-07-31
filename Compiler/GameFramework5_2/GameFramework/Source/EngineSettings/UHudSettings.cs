#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("HudSettings.h")]
public partial class UHudSettings : UObject {
	///<summary>Whether the HUD is visible at all.</summary>
	public bool bShowHUD;
	///<summary>Collection of names specifying what debug info to display for ViewTarget actor.</summary>
	public TArray<string> DebugDisplay;
}
