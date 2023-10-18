namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UGeometrySelectionManager provides the infrastructure for &quot;Element Selection&quot;, ie</summary>
[CppInclude("Selection/GeometrySelectionManager.h")]
public partial class UGeometrySelectionManager : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>This is set to current selection during CanExecuteSelectionCommand/ExecuteSelectionCommand, to keep the UObject alive</summary>
	public UGeometrySelectionEditCommandArguments SelectionArguments;
	///<summary>ITF references</summary>
	public UInteractiveToolsContext ToolsContext;
}
