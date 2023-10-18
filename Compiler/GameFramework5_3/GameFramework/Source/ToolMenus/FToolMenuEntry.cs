namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ToolMenuEntry.h")]
public partial struct FToolMenuEntry {
	public FName Name;
	public FToolMenuOwner Owner;
	public EMultiBlockType Type;
	public EUserInterfaceActionType UserInterfaceActionType;
	public FName TutorialHighlightName;
	public FToolMenuInsert InsertPosition;
	public bool bShouldCloseWindowAfterMenuSelection;
	public UToolMenuEntryScript ScriptObject;
	public FName StyleNameOverride;
	public bool bCommandIsKeybindOnly;
}
