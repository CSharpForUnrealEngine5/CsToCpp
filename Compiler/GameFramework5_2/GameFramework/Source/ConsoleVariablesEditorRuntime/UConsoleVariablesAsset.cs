#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConsoleVariablesAsset.h")]
///<summary>An asset used to track collections of console variables that can be recalled and edited using the Console Variables Editor.</summary>
public partial class UConsoleVariablesAsset : UObject {
// ConsoleVariablesAsset
	public  void SetVariableCollectionDescription(string InVariableCollectionDescription) {}
	public  string GetVariableCollectionDescription() { return default; }
	public  TArray<FConsoleVariablesEditorAssetSaveData> GetSavedCommands() { return default; }
	public  TArray<string> GetSavedCommandsAsStringArray(bool bOnlyIncludeChecked/*=false*/) { return default; }
	public  string GetSavedCommandsAsCommaSeparatedString(bool bOnlyIncludeChecked/*=false*/) { return default; }
	public  void ExecuteSavedCommands(UObject WorldContextObject,bool bOnlyIncludeChecked/*=false*/) {}
	public  void ReplaceSavedCommands(TArray<FConsoleVariablesEditorAssetSaveData> Replacement) {}
	public  int GetSavedCommandsCount() { return default; }
	public  bool FindSavedDataByCommandString(string InCommandString,FConsoleVariablesEditorAssetSaveData OutValue,ESearchCase SearchCase/*=ESearchCase.IgnoreCase*/) { return default; }
	public  void AddOrSetConsoleObjectSavedData(FConsoleVariablesEditorAssetSaveData InData) {}
	public  bool RemoveConsoleVariable(string InCommandString) { return default; }
	public  void CopyFrom(UConsoleVariablesAsset InAssetToCopy) {}
	public string VariableCollectionDescription;
	public TArray<FConsoleVariablesEditorAssetSaveData> SavedCommands;
}
