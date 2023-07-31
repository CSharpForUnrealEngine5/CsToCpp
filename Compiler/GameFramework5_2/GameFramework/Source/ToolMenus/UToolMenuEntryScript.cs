#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ToolMenuEntryScript.h")]
public partial class UToolMenuEntryScript : UObject {
	///<summary>Execute</summary>
	public  void Execute(FToolMenuContext Context) {}
	///<summary>CanExecute</summary>
	public  bool CanExecute(FToolMenuContext Context) { return default; }
	///<summary>GetCheckState</summary>
	public  ECheckBoxState GetCheckState(FToolMenuContext Context) { return default; }
	///<summary>IsVisible</summary>
	public  bool IsVisible(FToolMenuContext Context) { return default; }
	///<summary>GetLabel</summary>
	public  string GetLabel(FToolMenuContext Context) { return default; }
	///<summary>GetToolTip</summary>
	public  string GetToolTip(FToolMenuContext Context) { return default; }
	///<summary>GetIcon</summary>
	public  FScriptSlateIcon GetIcon(FToolMenuContext Context) { return default; }
	///<summary>ConstructMenuEntry</summary>
	public  void ConstructMenuEntry(UToolMenu Menu,string SectionName,FToolMenuContext Context) {}
	///<summary>RegisterMenuEntry</summary>
	public  void RegisterMenuEntry() {}
	///<summary>InitEntry</summary>
	public  void InitEntry(string OwnerName,string Menu,string Section,string Name,string Label/*=new FText()*/,string ToolTip/*=new FText()*/) {}
	///<summary>Data</summary>
	public FToolMenuEntryScriptData Data;
}
