namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ToolMenuEntryScript.h")]
public partial class UToolMenuEntryScript : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Execute</summary>
	public void Execute(FToolMenuContext Context) {}
	///<summary>CanExecute</summary>
	public bool CanExecute(FToolMenuContext Context) { return default; }
	///<summary>GetCheckState</summary>
	public ECheckBoxState GetCheckState(FToolMenuContext Context) { return default; }
	///<summary>IsVisible</summary>
	public bool IsVisible(FToolMenuContext Context) { return default; }
	///<summary>GetLabel</summary>
	public FText GetLabel(FToolMenuContext Context) { return default; }
	///<summary>GetToolTip</summary>
	public FText GetToolTip(FToolMenuContext Context) { return default; }
	///<summary>GetIcon</summary>
	public FScriptSlateIcon GetIcon(FToolMenuContext Context) { return default; }
	///<summary>ConstructMenuEntry</summary>
	public void ConstructMenuEntry(UToolMenu Menu,FName SectionName,FToolMenuContext Context) {}
	///<summary>RegisterMenuEntry</summary>
	public void RegisterMenuEntry() {}
	///<summary>InitEntry</summary>
	public void InitEntry(FName OwnerName,FName Menu,FName Section,FName Name,FText Label/*=new FText()*/,FText ToolTip/*=new FText()*/) {}
	///<summary>Data</summary>
	public FToolMenuEntryScriptData Data;
}
