#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Preferences/UnrealEdKeyBindings.h")]
public partial class UUnrealEdKeyBindings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Array of keybindings</summary>
	public TArray<FEditorKeyBinding> KeyBindings;
}
