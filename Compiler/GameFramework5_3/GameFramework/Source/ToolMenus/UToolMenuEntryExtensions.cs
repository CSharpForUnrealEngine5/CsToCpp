namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ToolMenusBlueprintLibrary.h")]
public partial class UToolMenuEntryExtensions : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>MakeScriptSlateIcon</summary>
	public static FScriptSlateIcon MakeScriptSlateIcon(FName StyleSetName,FName StyleName,FName SmallStyleName/*=NAME_None*/) { return default; }
	///<summary>BreakScriptSlateIcon</summary>
	public static void BreakScriptSlateIcon(FScriptSlateIcon InValue,FName StyleSetName,FName StyleName,FName SmallStyleName) {}
	///<summary>MakeStringCommand</summary>
	public static FToolMenuStringCommand MakeStringCommand(EToolMenuStringCommandType Type,FName CustomType,string String) { return default; }
	///<summary>BreakStringCommand</summary>
	public static void BreakStringCommand(FToolMenuStringCommand InValue,EToolMenuStringCommandType Type,FName CustomType,string String) {}
	///<summary>MakeToolMenuOwner</summary>
	public static FToolMenuOwner MakeToolMenuOwner(FName Name) { return default; }
	///<summary>BreakToolMenuOwner</summary>
	public static void BreakToolMenuOwner(FToolMenuOwner InValue,FName Name) {}
	///<summary>SetLabel</summary>
	public static void SetLabel(FToolMenuEntry Target,FText Label) {}
	///<summary>GetLabel</summary>
	public static FText GetLabel(FToolMenuEntry Target) { return default; }
	///<summary>SetToolTip</summary>
	public static void SetToolTip(FToolMenuEntry Target,FText ToolTip) {}
	///<summary>GetToolTip</summary>
	public static FText GetToolTip(FToolMenuEntry Target) { return default; }
	///<summary>SetIcon</summary>
	public static void SetIcon(FToolMenuEntry Target,FName StyleSetName,FName StyleName/*=NAME_None*/,FName SmallStyleName/*=NAME_None*/) {}
	///<summary>SetStringCommand</summary>
	public static void SetStringCommand(FToolMenuEntry Target,EToolMenuStringCommandType Type,FName CustomType,string String) {}
	///<summary>InitMenuEntry</summary>
	public static FToolMenuEntry InitMenuEntry(FName InOwner,FName InName,FText InLabel,FText InToolTip,EToolMenuStringCommandType CommandType,FName CustomCommandType,string CommandString) { return default; }
}
