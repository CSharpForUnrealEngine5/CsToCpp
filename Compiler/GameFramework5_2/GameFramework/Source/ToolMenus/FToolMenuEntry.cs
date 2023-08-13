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
