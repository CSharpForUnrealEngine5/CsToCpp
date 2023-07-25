#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ToolMenu.h")]
public partial class UToolMenu : UToolMenuBase {
// ToolMenu
	public void InitMenu(FToolMenuOwner Owner,string Name,string Parent/*=NAME_None*/,EMultiBoxType Type/*=EMultiBoxType.Menu*/) {}
	public void AddSectionScript(string SectionName,string Label/*=new FText()*/,string InsertName/*=NAME_None*/,EToolMenuInsertType InsertType/*=EToolMenuInsertType.Default*/) {}
	public void AddDynamicSectionScript(string SectionName,UObject Object) {}
	public void AddMenuEntry(string SectionName,FToolMenuEntry Args) {}
	public void AddMenuEntryObject(UObject InObject) {}
	public UObject AddSubMenuScript(string Owner,string SectionName,string Name,string Label,string ToolTip/*=new FText()*/) { return default; }
	public string MenuName;
	public string MenuParent;
	public string StyleName;
	public string TutorialHighlightName;
	public EMultiBoxType MenuType;
	public bool bShouldCleanupContextOnDestroy;
	public bool bShouldCloseWindowAfterMenuSelection;
	public bool bCloseSelfOnly;
	public bool bSearchable;
	public bool bToolBarIsFocusable;
	public bool bToolBarForceSmallIcons;
	public bool bPreventCustomization;
	public FToolMenuOwner MenuOwner;
	public FToolMenuContext Context;
	public TArray<FToolMenuSection> Sections;
	public UToolMenu SubMenuParent;
	public string SubMenuSourceEntryName;
}
