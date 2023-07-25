#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OutputLogSettings.h")]
///<summary>Implements the Editor style settings.</summary>
public partial class UOutputLogSettings : UObject {
// OutputLogSettings
	public int LogFontSize;
	public byte LogTimestampMode;
	public ELogCategoryColorizationMode CategoryColorizationMode;
	public bool bCycleToOutputLogDrawer;
	public bool bEnableOutputLogWordWrap;
	public bool bEnableOutputLogClearOnPIE;
}
