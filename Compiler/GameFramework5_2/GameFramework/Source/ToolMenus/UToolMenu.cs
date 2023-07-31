#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ToolMenu.h")]
public partial class UToolMenu : UToolMenuBase {
	///<summary>InitMenu</summary>
	public  void InitMenu(FToolMenuOwner Owner,string Name,string Parent/*=NAME_None*/,EMultiBoxType Type/*=EMultiBoxType.Menu*/) {}
	///<summary>AddSectionScript</summary>
	public  void AddSectionScript(string SectionName,string Label/*=new FText()*/,string InsertName/*=NAME_None*/,EToolMenuInsertType InsertType/*=EToolMenuInsertType.Default*/) {}
	///<summary>AddDynamicSectionScript</summary>
	public  void AddDynamicSectionScript(string SectionName,UToolMenuSectionDynamic Object) {}
	///<summary>AddMenuEntry</summary>
	public  void AddMenuEntry(string SectionName,FToolMenuEntry Args) {}
	///<summary>AddMenuEntryObject</summary>
	public  void AddMenuEntryObject(UToolMenuEntryScript InObject) {}
	///<summary>AddSubMenuScript</summary>
	public  UToolMenu AddSubMenuScript(string Owner,string SectionName,string Name,string Label,string ToolTip/*=new FText()*/) { return default; }
	///<summary>MenuName</summary>
	public string MenuName;
	///<summary>MenuParent</summary>
	public string MenuParent;
	///<summary>StyleName</summary>
	public string StyleName;
	///<summary>TutorialHighlightName</summary>
	public string TutorialHighlightName;
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
	public string SubMenuSourceEntryName;
}
