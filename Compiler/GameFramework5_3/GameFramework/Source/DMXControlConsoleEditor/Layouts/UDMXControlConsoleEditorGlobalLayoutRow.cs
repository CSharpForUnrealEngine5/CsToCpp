namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A row of Fader Groups in the Control Console Global Layout</summary>
[CppInclude("Layouts/DMXControlConsoleEditorGlobalLayoutRow.h")]
public partial class UDMXControlConsoleEditorGlobalLayoutRow : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Reference to Fader Groups array</summary>
	public TArray<TWeakObjectPtr<UDMXControlConsoleFaderGroup>> FaderGroups;
}
