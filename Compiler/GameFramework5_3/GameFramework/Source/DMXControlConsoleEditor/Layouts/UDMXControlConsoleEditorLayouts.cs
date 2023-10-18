namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Control Console container class for layouts data</summary>
[CppInclude("Layouts/DMXControlConsoleEditorLayouts.h")]
public partial class UDMXControlConsoleEditorLayouts : UDMXControlConsoleEditorLayoutsBase {
	public static UClass StaticClass() {return default;}
	///<summary>Reference to Default Layout</summary>
	public UDMXControlConsoleEditorGlobalLayoutDefault DefaultLayout;
	///<summary>Array of User Layouts</summary>
	public TArray<UDMXControlConsoleEditorGlobalLayoutUser> UserLayouts;
	///<summary>Reference to active Layout in use</summary>
	public UDMXControlConsoleEditorGlobalLayoutBase ActiveLayout;
}
