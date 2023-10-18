namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Command to Invert the current Selection, only considering connected geometry</summary>
[CppInclude("Commands/ModifyGeometrySelectionCommand.h")]
public partial class UModifyGeometrySelectionCommand_InvertConnected : UModifyGeometrySelectionCommand {
	public static UClass StaticClass() {return default;}
}
