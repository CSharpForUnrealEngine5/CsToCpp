namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Default StateTree settings</summary>
[CppInclude("StateTreeSettings.h")]
public partial class UStateTreeSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Editor targets relies on PIE and StateTreeEditor to start/stop traces.</summary>
	public bool bAutoStartDebuggerTracesOnNonEditorTargets;
}
