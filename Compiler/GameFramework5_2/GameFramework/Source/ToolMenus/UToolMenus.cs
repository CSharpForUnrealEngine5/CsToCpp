#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ToolMenus.h")]
public partial class UToolMenus : UObject {
// ToolMenus
	public UObject Get() { return default; }
	public UObject RegisterMenu(string Name,string Parent/*=NAME_None*/,EMultiBoxType Type/*=EMultiBoxType.Menu*/,bool bWarnIfAlreadyRegistered/*=true*/) { return default; }
	public UObject ExtendMenu(string Name) { return default; }
	public UObject FindMenu(string Name) { return default; }
	public bool IsMenuRegistered(string Name) { return default; }
	public bool RefreshMenuWidget(string Name) { return default; }
	public void RefreshAllWidgets() {}
	public bool AddMenuEntryObject(UObject MenuEntryObject) { return default; }
	public void UnregisterOwnerByName(string InOwnerName) {}
	public void SetSectionLabel(string MenuName,string SectionName,string Label) {}
	public void SetSectionPosition(string MenuName,string SectionName,string OtherSectionName,EToolMenuInsertType PositionType) {}
	public void RemoveEntry(string MenuName,string Section,string Name) {}
	public void RemoveSection(string MenuName,string Section) {}
	public void RemoveMenu(string MenuName) {}
	public UObject FindContext(FToolMenuContext InContext,UClass InClass) { return default; }
	public TArray<FCustomizedToolMenu> CustomizedMenus;
	public TMap<string,string> MenuSubstitutionsDuringGenerate;
	public TMap<string,UToolMenu> Menus;
}
