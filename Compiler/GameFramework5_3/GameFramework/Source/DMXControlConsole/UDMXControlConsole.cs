namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The DMX Control Console</summary>
[CppInclude("DMXControlConsole.h")]
public partial class UDMXControlConsole : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Control Console Layouts data reference</summary>
	public UDMXControlConsoleEditorLayoutsBase ControlConsoleEditorLayouts;
	///<summary>Control Console Data reference</summary>
	public UDMXControlConsoleData ControlConsoleData;
}
