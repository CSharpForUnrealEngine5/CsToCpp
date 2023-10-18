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
	///<summary>Fixture Patch List default descriptor saved in config</summary>
	public FDMXReadOnlyFixturePatchListDescriptor FixturePatchListDescriptor;
	///<summary>True if Fader Groups from activated Fixture Patches must be selected by default</summary>
	public bool bAutoSelectActivePatches;
	///<summary>True if filtered Elements must be selected by default</summary>
	public bool bAutoSelectFilteredElements;
}
