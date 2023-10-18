namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A layout where Control Console data are sorted by default</summary>
[CppInclude("Layouts/DMXControlConsoleEditorGlobalLayoutDefault.h")]
public partial class UDMXControlConsoleEditorGlobalLayoutDefault : UDMXControlConsoleEditorGlobalLayoutBase {
	public static UClass StaticClass() {return default;}
	///<summary>Array of currently active Fader Groups in the layout</summary>
	public TArray<TWeakObjectPtr<UDMXControlConsoleFaderGroup>> ActiveFaderGroups;
}
