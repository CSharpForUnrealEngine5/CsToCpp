#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements the Editor style settings.</summary>
[CppInclude("OutputLogSettings.h")]
public partial class UOutputLogSettings : UObject {
	///<summary>The font size used in the output log</summary>
	public int LogFontSize;
	///<summary>The display mode for timestamps in the output log window</summary>
	public ELogTimes LogTimestampMode;
	///<summary>How should categories be colorized in the output log?</summary>
	public ELogCategoryColorizationMode CategoryColorizationMode;
	///<summary>If checked pressing the console command shortcut will cycle between focusing the status bar console, opening the output log drawer, and back to the previous focus target.</summary>
	public bool bCycleToOutputLogDrawer;
	///<summary>bEnableOutputLogWordWrap</summary>
	public bool bEnableOutputLogWordWrap;
	///<summary>bEnableOutputLogClearOnPIE</summary>
	public bool bEnableOutputLogClearOnPIE;
}
