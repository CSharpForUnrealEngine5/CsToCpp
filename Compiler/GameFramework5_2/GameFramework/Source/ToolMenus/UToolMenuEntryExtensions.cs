#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ToolMenusBlueprintLibrary.h")]
public partial class UToolMenuEntryExtensions : UObject {
// ToolMenuEntryExtensions
	public FScriptSlateIcon MakeScriptSlateIcon(string StyleSetName,string StyleName,string SmallStyleName/*=NAME_None*/) { return default; }
	public void BreakScriptSlateIcon(FScriptSlateIcon InValue,string StyleSetName,string StyleName,string SmallStyleName) {}
	public FToolMenuStringCommand MakeStringCommand(EToolMenuStringCommandType Type,string CustomType,string String) { return default; }
	public void BreakStringCommand(FToolMenuStringCommand InValue,EToolMenuStringCommandType Type,string CustomType,string String) {}
	public FToolMenuOwner MakeToolMenuOwner(string Name) { return default; }
	public void BreakToolMenuOwner(FToolMenuOwner InValue,string Name) {}
	public void SetLabel(FToolMenuEntry Target,string Label) {}
	public string GetLabel(FToolMenuEntry Target) { return default; }
	public void SetToolTip(FToolMenuEntry Target,string ToolTip) {}
	public string GetToolTip(FToolMenuEntry Target) { return default; }
	public void SetIcon(FToolMenuEntry Target,string StyleSetName,string StyleName/*=NAME_None*/,string SmallStyleName/*=NAME_None*/) {}
	public void SetStringCommand(FToolMenuEntry Target,EToolMenuStringCommandType Type,string CustomType,string String) {}
	public FToolMenuEntry InitMenuEntry(string InOwner,string InName,string InLabel,string InToolTip,EToolMenuStringCommandType CommandType,string CustomCommandType,string CommandString) { return default; }
}
