namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ToolMenu.h")]
public partial class UToolMenu : UToolMenuBase {
	public static UClass StaticClass() {return default;}
	///<summary>InitMenu</summary>
	public void InitMenu(FToolMenuOwner Owner,FName Name,FName Parent/*=NAME_None*/,EMultiBoxType Type/*=EMultiBoxType.Menu*/) {}
	///<summary>AddSectionScript</summary>
	public void AddSectionScript(FName SectionName,FText Label/*=new FText()*/,FName InsertName/*=NAME_None*/,EToolMenuInsertType InsertType/*=EToolMenuInsertType.Default*/) {}
	///<summary>AddDynamicSectionScript</summary>
	public void AddDynamicSectionScript(FName SectionName,UToolMenuSectionDynamic Object) {}
	///<summary>AddMenuEntry</summary>
	public void AddMenuEntry(FName SectionName,FToolMenuEntry Args) {}
	///<summary>AddMenuEntryObject</summary>
	public void AddMenuEntryObject(UToolMenuEntryScript InObject) {}
	///<summary>AddSubMenuScript</summary>
	public UToolMenu AddSubMenuScript(FName Owner,FName SectionName,FName Name,FText Label,FText ToolTip/*=new FText()*/) { return default; }
	///<summary>MenuName</summary>
	public FName MenuName;
	///<summary>MenuParent</summary>
	public FName MenuParent;
	///<summary>StyleName</summary>
	public FName StyleName;
	///<summary>TutorialHighlightName</summary>
	public FName TutorialHighlightName;
	///<summary>MenuType</summary>
	public EMultiBoxType MenuType;
	///<summary>bShouldCleanupContextOnDestroy</summary>
	public bool bShouldCleanupContextOnDestroy;
	///<summary>bShouldCloseWindowAfterMenuSelection</summary>
	public bool bShouldCloseWindowAfterMenuSelection;
	///<summary>bCloseSelfOnly</summary>
	public bool bCloseSelfOnly;
	///<summary>bSearchable</summary>
	public bool bSearchable;
	///<summary>bToolBarIsFocusable</summary>
	public bool bToolBarIsFocusable;
	///<summary>bToolBarForceSmallIcons</summary>
	public bool bToolBarForceSmallIcons;
	///<summary>Prevent menu from being customized</summary>
	public bool bPreventCustomization;
	///<summary>MenuOwner</summary>
	public FToolMenuOwner MenuOwner;
	///<summary>Context</summary>
	public FToolMenuContext Context;
	///<summary>Sections</summary>
	public TArray<FToolMenuSection> Sections;
	///<summary>SubMenuParent</summary>
	public UToolMenu SubMenuParent;
	///<summary>SubMenuSourceEntryName</summary>
	public FName SubMenuSourceEntryName;
}
