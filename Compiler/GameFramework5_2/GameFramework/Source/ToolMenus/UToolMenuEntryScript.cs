#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ToolMenuEntryScript.h")]
public partial class UToolMenuEntryScript : UObject {
// ToolMenuEntryScript
	public void Execute(FToolMenuContext Context) {}
	public bool CanExecute(FToolMenuContext Context) { return default; }
	public ECheckBoxState GetCheckState(FToolMenuContext Context) { return default; }
	public bool IsVisible(FToolMenuContext Context) { return default; }
	public string GetLabel(FToolMenuContext Context) { return default; }
	public string GetToolTip(FToolMenuContext Context) { return default; }
	public FScriptSlateIcon GetIcon(FToolMenuContext Context) { return default; }
	public void ConstructMenuEntry(UObject Menu,string SectionName,FToolMenuContext Context) {}
	public void RegisterMenuEntry() {}
	public void InitEntry(string OwnerName,string Menu,string Section,string Name,string Label/*=new FText()*/,string ToolTip/*=new FText()*/) {}
	public FToolMenuEntryScriptData Data;
}
