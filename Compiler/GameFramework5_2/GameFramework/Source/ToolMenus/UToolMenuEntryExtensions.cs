#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ToolMenusBlueprintLibrary.h")]
public partial class UToolMenuEntryExtensions : UObject {
	///<summary>MakeScriptSlateIcon</summary>
	public static FScriptSlateIcon MakeScriptSlateIcon(string StyleSetName,string StyleName,string SmallStyleName/*=NAME_None*/) { return default; }
	///<summary>BreakScriptSlateIcon</summary>
	public static void BreakScriptSlateIcon(FScriptSlateIcon InValue,string StyleSetName,string StyleName,string SmallStyleName) {}
	///<summary>MakeStringCommand</summary>
	public static FToolMenuStringCommand MakeStringCommand(EToolMenuStringCommandType Type,string CustomType,string String) { return default; }
	///<summary>BreakStringCommand</summary>
	public static void BreakStringCommand(FToolMenuStringCommand InValue,EToolMenuStringCommandType Type,string CustomType,string String) {}
	///<summary>MakeToolMenuOwner</summary>
	public static FToolMenuOwner MakeToolMenuOwner(string Name) { return default; }
	///<summary>BreakToolMenuOwner</summary>
	public static void BreakToolMenuOwner(FToolMenuOwner InValue,string Name) {}
	///<summary>SetLabel</summary>
	public static void SetLabel(FToolMenuEntry Target,string Label) {}
	///<summary>GetLabel</summary>
	public static string GetLabel(FToolMenuEntry Target) { return default; }
	///<summary>SetToolTip</summary>
	public static void SetToolTip(FToolMenuEntry Target,string ToolTip) {}
	///<summary>GetToolTip</summary>
	public static string GetToolTip(FToolMenuEntry Target) { return default; }
	///<summary>SetIcon</summary>
	public static void SetIcon(FToolMenuEntry Target,string StyleSetName,string StyleName/*=NAME_None*/,string SmallStyleName/*=NAME_None*/) {}
	///<summary>SetStringCommand</summary>
	public static void SetStringCommand(FToolMenuEntry Target,EToolMenuStringCommandType Type,string CustomType,string String) {}
	///<summary>InitMenuEntry</summary>
	public static FToolMenuEntry InitMenuEntry(string InOwner,string InName,string InLabel,string InToolTip,EToolMenuStringCommandType CommandType,string CustomCommandType,string CommandString) { return default; }
}
