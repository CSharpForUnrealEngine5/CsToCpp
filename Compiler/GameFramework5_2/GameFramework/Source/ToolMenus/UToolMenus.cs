#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ToolMenus.h")]
public partial class UToolMenus : UObject {
	///<summary>Get</summary>
	public static UToolMenus Get() { return default; }
	///<summary>Registers a menu by name</summary>
	public  UToolMenu RegisterMenu(string Name,string Parent/*=NAME_None*/,EMultiBoxType Type/*=EMultiBoxType.Menu*/,bool bWarnIfAlreadyRegistered/*=true*/) { return default; }
	///<summary>Extends a menu without registering the menu or claiming ownership of it. Ok to call even if menu does not exist yet.</summary>
	public  UToolMenu ExtendMenu(string Name) { return default; }
	///<summary>Finds an existing menu that has been registered or extended.</summary>
	public  UToolMenu FindMenu(string Name) { return default; }
	///<summary>Determines if a menu has already been registered.</summary>
	public  bool IsMenuRegistered(string Name) { return default; }
	///<summary>Rebuilds all widgets generated from a specific menu.</summary>
	public  bool RefreshMenuWidget(string Name) { return default; }
	///<summary>Rebuilds all currently generated widgets next tick.</summary>
	public  void RefreshAllWidgets() {}
	///<summary>Registers menu entry object from blueprint/script</summary>
	public static bool AddMenuEntryObject(UToolMenuEntryScript MenuEntryObject) { return default; }
	///<summary>Removes all entries that were registered under a specific owner name</summary>
	public  void UnregisterOwnerByName(string InOwnerName) {}
	///<summary>Sets a section&#39;s displayed label text.</summary>
	public  void SetSectionLabel(string MenuName,string SectionName,string Label) {}
	///<summary>Sets where to insert a section into a menu when generating relative to other section names.</summary>
	public  void SetSectionPosition(string MenuName,string SectionName,string OtherSectionName,EToolMenuInsertType PositionType) {}
	///<summary>Removes a menu entry from a given menu and section</summary>
	public  void RemoveEntry(string MenuName,string Section,string Name) {}
	///<summary>Removes a section from a given menu</summary>
	public  void RemoveSection(string MenuName,string Section) {}
	///<summary>Unregisters a menu by name</summary>
	public  void RemoveMenu(string MenuName) {}
	///<summary>Finds a context object of a given class if it exists</summary>
	public static UObject FindContext(FToolMenuContext InContext,UClass InClass) { return default; }
	///<summary>CustomizedMenus</summary>
	public TArray<FCustomizedToolMenu> CustomizedMenus;
	///<summary>Allow substituting one menu for another during generate but not during find or extend</summary>
	public TMap<string,string> MenuSubstitutionsDuringGenerate;
	///<summary>Menus</summary>
	public TMap<string,UToolMenu> Menus;
}
