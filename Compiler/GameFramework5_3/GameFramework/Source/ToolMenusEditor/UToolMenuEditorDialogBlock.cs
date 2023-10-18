namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ToolMenusEditor.h")]
public partial class UToolMenuEditorDialogBlock : UToolMenuEditorDialogObject {
	public static UClass StaticClass() {return default;}
	///<summary>Name</summary>
	public FName Name;
	///<summary>Type</summary>
	public ESelectedEditMenuEntryType Type;
	///<summary>Visibility</summary>
	public ECustomizedToolMenuVisibility Visibility;
	///<summary>Menu</summary>
	public UToolMenu Menu;
}
