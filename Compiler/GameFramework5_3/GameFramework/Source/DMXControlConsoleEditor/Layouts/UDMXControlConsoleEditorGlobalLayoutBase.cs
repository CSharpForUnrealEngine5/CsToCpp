namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for Control Console layout</summary>
[CppInclude("Layouts/DMXControlConsoleEditorGlobalLayoutBase.h")]
public partial class UDMXControlConsoleEditorGlobalLayoutBase : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Reference to Layout Rows array</summary>
	public TArray<UDMXControlConsoleEditorGlobalLayoutRow> LayoutRows;
	///<summary>Current layout sorting method for this layout</summary>
	public EDMXControlConsoleLayoutMode LayoutMode;
}
