#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Model of the console currently being edited in the control console editor.</summary>
[CppInclude("Models/DMXControlConsoleEditorModel.h")]
public partial class UDMXControlConsoleEditorModel : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The currently edited console</summary>
	public UDMXControlConsole EditorConsole;
	///<summary>Control console saved in config</summary>
	public FSoftObjectPath DefaultConsolePath;
}
