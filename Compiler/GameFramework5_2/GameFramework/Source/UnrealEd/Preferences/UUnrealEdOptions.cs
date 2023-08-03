#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Preferences/UnrealEdOptions.h")]
public partial class UUnrealEdOptions : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Categories of commands.</summary>
	public TArray<FEditorCommandCategory> EditorCategories;
	///<summary>Commands that can be bound to in the editor.</summary>
	public TArray<FEditorCommand> EditorCommands;
	///<summary>Pointer to the key bindings object that actually stores key bindings for the editor.</summary>
	public UUnrealEdKeyBindings EditorKeyBindings;
	///<summary>If true, the list of classes in the class picker dialog will be expanded</summary>
	public bool bExpandClassPickerClassList;
	///<summary>The array of default objects in the blueprint class dialog *</summary>
	public TArray<FClassPickerDefaults> NewAssetDefaultClasses;
}
