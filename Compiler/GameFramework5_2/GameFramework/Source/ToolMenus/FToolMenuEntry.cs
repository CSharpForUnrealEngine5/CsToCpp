#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ToolMenuEntry.h")]
public partial struct FToolMenuEntry {
// ToolMenuEntry
	public string Name;
	public FToolMenuOwner Owner;
	public EMultiBlockType Type;
	public EUserInterfaceActionType UserInterfaceActionType;
	public string TutorialHighlightName;
	public FToolMenuInsert InsertPosition;
	public bool bShouldCloseWindowAfterMenuSelection;
	public UToolMenuEntryScript ScriptObject;
	public string StyleNameOverride;
	public bool bCommandIsKeybindOnly;
}
