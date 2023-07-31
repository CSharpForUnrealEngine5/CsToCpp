#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UGeometrySelectionManager provides the infrastructure for &quot;Element Selection&quot;, ie</summary>
[CppInclude("Selection/GeometrySelectionManager.h")]
public partial class UGeometrySelectionManager : UObject {
	///<summary>This is set to current selection during CanExecuteSelectionCommand/ExecuteSelectionCommand, to keep the UObject alive</summary>
	public UGeometrySelectionEditCommandArguments SelectionArguments;
	///<summary>ITF references</summary>
	public UInteractiveToolsContext ToolsContext;
}
