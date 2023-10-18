namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("StateTreeEditorSettings.h")]
public partial class UStateTreeEditorSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Determines when to save StateTrees post-compile</summary>
	public EStateTreeSaveOnCompile SaveOnCompile;
	///<summary>If enabled, debugger starts recording information at the start of each PIE session.</summary>
	public bool bShouldDebuggerAutoRecordOnPIE;
	///<summary>If enabled, debugger will clear previous tracks at the start of each PIE session.</summary>
	public bool bShouldDebuggerResetDataOnNewPIESession;
}
