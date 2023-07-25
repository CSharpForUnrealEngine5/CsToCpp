#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConsoleVariablesEditorFunctionLibrary.h")]
///<summary>An asset used to track collections of console variables that can be recalled and edited using the Console Variables Editor.</summary>
public partial class UConsoleVariablesEditorFunctionLibrary : UBlueprintFunctionLibrary {
// ConsoleVariablesEditorFunctionLibrary
	public UObject GetCurrentlyLoadedPreset() { return default; }
	public void LoadPresetIntoConsoleVariablesEditor(UObject InAsset) {}
	public bool CopyCurrentListToAsset(UObject InAsset) { return default; }
	public bool AddValidatedCommandToCurrentPreset(string NewCommand) { return default; }
	public bool RemoveCommandFromCurrentPreset(string NewCommand) { return default; }
	public bool GetListOfCommandsFromPreset(UObject InAsset,TArray<string> OutCommandList) { return default; }
	public bool SetConsoleVariableByName_Float(string InCommandName,float InValue) { return default; }
	public bool SetConsoleVariableByName_Bool(string InCommandName,bool InValue) { return default; }
	public bool SetConsoleVariableByName_Int(string InCommandName,int InValue) { return default; }
	public bool SetConsoleVariableByName_String(string InCommandName,string InValue) { return default; }
	public bool GetConsoleVariableStringValue(string InCommandName,string OutValue) { return default; }
	public bool GetConsoleVariableSourceByName(string InCommandName,string OutValue) { return default; }
	public bool GetEnableMultiUserCVarSync() { return default; }
	public void SetEnableMultiUserCVarSync(bool bNewSetting) {}
}
