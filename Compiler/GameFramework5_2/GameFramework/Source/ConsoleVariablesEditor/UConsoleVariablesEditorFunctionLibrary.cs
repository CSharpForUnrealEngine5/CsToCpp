#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An asset used to track collections of console variables that can be recalled and edited using the Console Variables Editor.</summary>
[CppInclude("ConsoleVariablesEditorFunctionLibrary.h")]
public partial class UConsoleVariablesEditorFunctionLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Return the currently loaded list of variables in the Console Variables Editor.</summary>
	public static UConsoleVariablesAsset GetCurrentlyLoadedPreset() { return default; }
	///<summary>Loads the given asset in the Console Variables Editor and sets all its variable values.</summary>
	public static void LoadPresetIntoConsoleVariablesEditor(UConsoleVariablesAsset InAsset) {}
	///<summary>* Saves the current list in the Console Variables Editor to the given asset.</summary>
	public static bool CopyCurrentListToAsset(UConsoleVariablesAsset InAsset) { return default; }
	///<summary>* Adds a validated command to the current preset with its current value.</summary>
	public static bool AddValidatedCommandToCurrentPreset(string NewCommand) { return default; }
	///<summary>* Removes a command from the current preset if it exists in the saved data.</summary>
	public static bool RemoveCommandFromCurrentPreset(string NewCommand) { return default; }
	///<summary>Return an array of strings containing the command names for each command found in the given preset.</summary>
	public static bool GetListOfCommandsFromPreset(UConsoleVariablesAsset InAsset,TArray<string> OutCommandList) { return default; }
	///<summary>Set a console variable value directly. Returns true if the console object exists.</summary>
	public static bool SetConsoleVariableByName_Float(string InCommandName,float InValue) { return default; }
	///<summary>Set a console variable value directly. Returns true if the console object exists.</summary>
	public static bool SetConsoleVariableByName_Bool(string InCommandName,bool InValue) { return default; }
	///<summary>Set a console variable value directly. Returns true if the console object exists.</summary>
	public static bool SetConsoleVariableByName_Int(string InCommandName,int InValue) { return default; }
	///<summary>Set a console variable value directly. Returns true if the console object exists.</summary>
	public static bool SetConsoleVariableByName_String(string InCommandName,string InValue) { return default; }
	///<summary>Get a console variable&#39;s string value directly. Returns true if the console object exists.</summary>
	public static bool GetConsoleVariableStringValue(string InCommandName,string OutValue) { return default; }
	///<summary>Set a console variable value directly. Returns true if the console object exists.</summary>
	public static bool GetConsoleVariableSourceByName(string InCommandName,string OutValue) { return default; }
	///<summary>Return whether the Multi-user sync setting for the current instance of the editor is enabled.</summary>
	public static bool GetEnableMultiUserCVarSync() { return default; }
	///<summary>Enable or disable the Multi-user sync setting for the current instance of the editor.</summary>
	public static void SetEnableMultiUserCVarSync(bool bNewSetting) {}
}
