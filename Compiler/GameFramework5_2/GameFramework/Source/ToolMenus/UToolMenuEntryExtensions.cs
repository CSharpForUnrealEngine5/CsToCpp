#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ToolMenusBlueprintLibrary.h")]
public partial class UToolMenuEntryExtensions : UObject {
// ToolMenuEntryExtensions
	public static FScriptSlateIcon MakeScriptSlateIcon(string StyleSetName,string StyleName,string SmallStyleName/*=NAME_None*/) { return default; }
	public static void BreakScriptSlateIcon(FScriptSlateIcon InValue,string StyleSetName,string StyleName,string SmallStyleName) {}
	public static FToolMenuStringCommand MakeStringCommand(EToolMenuStringCommandType Type,string CustomType,string String) { return default; }
	public static void BreakStringCommand(FToolMenuStringCommand InValue,EToolMenuStringCommandType Type,string CustomType,string String) {}
	public static FToolMenuOwner MakeToolMenuOwner(string Name) { return default; }
	public static void BreakToolMenuOwner(FToolMenuOwner InValue,string Name) {}
	public static void SetLabel(FToolMenuEntry Target,string Label) {}
	public static string GetLabel(FToolMenuEntry Target) { return default; }
	public static void SetToolTip(FToolMenuEntry Target,string ToolTip) {}
	public static string GetToolTip(FToolMenuEntry Target) { return default; }
	public static void SetIcon(FToolMenuEntry Target,string StyleSetName,string StyleName/*=NAME_None*/,string SmallStyleName/*=NAME_None*/) {}
	public static void SetStringCommand(FToolMenuEntry Target,EToolMenuStringCommandType Type,string CustomType,string String) {}
	public static FToolMenuEntry InitMenuEntry(string InOwner,string InName,string InLabel,string InToolTip,EToolMenuStringCommandType CommandType,string CustomCommandType,string CommandString) { return default; }
}
