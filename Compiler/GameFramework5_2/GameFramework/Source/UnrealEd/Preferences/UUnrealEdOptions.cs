#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Preferences/UnrealEdOptions.h")]
public partial class UUnrealEdOptions : UObject {
// UnrealEdOptions
	public TArray<FEditorCommandCategory> EditorCategories;
	public TArray<FEditorCommand> EditorCommands;
	public UUnrealEdKeyBindings EditorKeyBindings;
	public bool bExpandClassPickerClassList;
	public TArray<FClassPickerDefaults> NewAssetDefaultClasses;
}
