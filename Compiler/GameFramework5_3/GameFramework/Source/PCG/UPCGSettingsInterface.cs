namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PCGSettings.h")]
public partial class UPCGSettingsInterface : UPCGData {
	public static UClass StaticClass() {return default;}
	///<summary>bEnabled</summary>
	public bool bEnabled;
	///<summary>bDebug</summary>
	public bool bDebug;
	///<summary>DebugSettings</summary>
	public FPCGDebugVisualizationSettings DebugSettings;
	///<summary>If a debugger is attached, triggers a breakpoint inside IPCGElement::Execute(). Editor only. Transient.</summary>
	public bool bBreakDebugger;
}
