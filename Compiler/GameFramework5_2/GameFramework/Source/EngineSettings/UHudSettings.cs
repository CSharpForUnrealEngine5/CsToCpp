namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("HudSettings.h")]
public partial class UHudSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Whether the HUD is visible at all.</summary>
	public bool bShowHUD;
	///<summary>Collection of names specifying what debug info to display for ViewTarget actor.</summary>
	public TArray<FName> DebugDisplay;
}
