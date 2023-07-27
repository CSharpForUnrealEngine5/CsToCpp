#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConsoleVariablesEditorFunctionLibrary.h")]
///<summary>An asset used to track collections of console variables that can be recalled and edited using the Console Variables Editor.</summary>
public partial class UConsoleVariablesEditorFunctionLibrary : UBlueprintFunctionLibrary {
// ConsoleVariablesEditorFunctionLibrary
	public static UConsoleVariablesAsset GetCurrentlyLoadedPreset() { return default; }
	public static void LoadPresetIntoConsoleVariablesEditor(UConsoleVariablesAsset InAsset) {}
	public static bool CopyCurrentListToAsset(UConsoleVariablesAsset InAsset) { return default; }
	public static bool AddValidatedCommandToCurrentPreset(string NewCommand) { return default; }
	public static bool RemoveCommandFromCurrentPreset(string NewCommand) { return default; }
	public static bool GetListOfCommandsFromPreset(UConsoleVariablesAsset InAsset,TArray<string> OutCommandList) { return default; }
	public static bool SetConsoleVariableByName_Float(string InCommandName,float InValue) { return default; }
	public static bool SetConsoleVariableByName_Bool(string InCommandName,bool InValue) { return default; }
	public static bool SetConsoleVariableByName_Int(string InCommandName,int InValue) { return default; }
	public static bool SetConsoleVariableByName_String(string InCommandName,string InValue) { return default; }
	public static bool GetConsoleVariableStringValue(string InCommandName,string OutValue) { return default; }
	public static bool GetConsoleVariableSourceByName(string InCommandName,string OutValue) { return default; }
	public static bool GetEnableMultiUserCVarSync() { return default; }
	public static void SetEnableMultiUserCVarSync(bool bNewSetting) {}
}
