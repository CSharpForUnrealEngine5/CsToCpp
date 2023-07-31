#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ToolMenuEntry.h")]
public partial struct FToolMenuEntry {
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
