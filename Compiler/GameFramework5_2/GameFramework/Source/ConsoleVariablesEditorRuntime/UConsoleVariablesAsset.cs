#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An asset used to track collections of console variables that can be recalled and edited using the Console Variables Editor.</summary>
[CppInclude("ConsoleVariablesAsset.h")]
public partial class UConsoleVariablesAsset : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Sets a description for this variable collection.</summary>
	public  void SetVariableCollectionDescription(string InVariableCollectionDescription) {}
	///<summary>GetVariableCollectionDescription</summary>
	public  string GetVariableCollectionDescription() { return default; }
	///<summary>Returns the saved list of console variable information such as the variable name, the type and the value of the variable at the time the asset was saved.</summary>
	public  TArray<FConsoleVariablesEditorAssetSaveData> GetSavedCommands() { return default; }
	///<summary>Returns the saved list of console variables as an array of FString.</summary>
	public  TArray<string> GetSavedCommandsAsStringArray(bool bOnlyIncludeChecked/*=false*/) { return default; }
	///<summary>Returns the saved list of console variables as a concatenated comma-separated string. Useful for passing commands and variables to a command line.</summary>
	public  string GetSavedCommandsAsCommaSeparatedString(bool bOnlyIncludeChecked/*=false*/) { return default; }
	///<summary>Executes all saved commands in this asset, optionally only including those with a Checked checkstate in the UI.</summary>
	public  void ExecuteSavedCommands(UObject WorldContextObject,bool bOnlyIncludeChecked/*=false*/) {}
	///<summary>Completely replaces the saved data with new saved data</summary>
	public  void ReplaceSavedCommands(TArray<FConsoleVariablesEditorAssetSaveData> Replacement) {}
	///<summary>Returns how many console variables are serialized in this asset</summary>
	public  int GetSavedCommandsCount() { return default; }
	///<summary>Outputs the FConsoleVariablesEditorAssetSaveData matching InCommand. Returns whether a match was found. Case sensitive.</summary>
	public  bool FindSavedDataByCommandString(string InCommandString,FConsoleVariablesEditorAssetSaveData OutValue,ESearchCase SearchCase/*=ESearchCase.IgnoreCase*/) { return default; }
	///<summary>Set the value of a saved console variable if the name matches; add a new console variable to the list if a match is not found.</summary>
	public  void AddOrSetConsoleObjectSavedData(FConsoleVariablesEditorAssetSaveData InData) {}
	///<summary>Returns true if the element was found and successfully removed.</summary>
	public  bool RemoveConsoleVariable(string InCommandString) { return default; }
	///<summary>Copy data from input asset to this asset</summary>
	public  void CopyFrom(UConsoleVariablesAsset InAssetToCopy) {}
	///<summary>User defined description of the variable collection</summary>
	public string VariableCollectionDescription;
	///<summary>A saved list of console variable information such as the variable name, the type and the value of the variable at the time the asset was saved.</summary>
	public TArray<FConsoleVariablesEditorAssetSaveData> SavedCommands;
}
