#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ToolMenusEditor.h")]
public partial class UToolMenuEditorDialogBlock : UToolMenuEditorDialogObject {
	///<summary>Name</summary>
	public string Name;
	///<summary>Type</summary>
	public ESelectedEditMenuEntryType Type;
	///<summary>Visibility</summary>
	public ECustomizedToolMenuVisibility Visibility;
	///<summary>Menu</summary>
	public UToolMenu Menu;
}
