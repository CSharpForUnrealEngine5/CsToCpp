namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>*  Typically an Editor&#39;s Subsystem would be where the actual Asset editing happens -- when the user presses a button in</summary>
[CppInclude("ExampleCharacterFXEditorSubsystem.h")]
public partial class UExampleCharacterFXEditorSubsystem : UEditorSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>Used to let the subsystem figure out whether targets are valid. New factories should be</summary>
	public UToolTargetManager ToolTargetManager;
}
