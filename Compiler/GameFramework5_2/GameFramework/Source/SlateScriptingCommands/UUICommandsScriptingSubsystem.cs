#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UICommandsScriptingSubsystem.h")]
///<summary>UEditorInputSubsystem</summary>
public partial class UUICommandsScriptingSubsystem : UEngineSubsystem {
// UICommandsScriptingSubsystem
	public  bool RegisterCommand(FScriptingCommandInfo CommandInfo,FExecuteCommand OnExecuteCommand,bool bOverrideExisting/*=false*/) { return default; }
	public  bool RegisterCommandChecked(FScriptingCommandInfo CommandInfo,FExecuteCommand OnExecuteCommand,FCanExecuteCommand OnCanExecuteCommand,bool bOverrideExisting/*=false*/) { return default; }
	public  bool UnregisterCommand(FScriptingCommandInfo CommandInfo) { return default; }
	public  bool IsCommandRegistered(FScriptingCommandInfo CommandInfo,bool bCheckInputChord/*=true*/) { return default; }
	public  TArray<FScriptingCommandInfo> GetRegisteredCommands() { return default; }
	public  bool CanExecuteCommands() { return default; }
	public  void SetCanExecuteCommands(bool bShouldExecuteCommands) {}
	public  void UnregisterAllSets() {}
	public  bool RegisterCommandSet(string SetName) { return default; }
	public  bool IsCommandSetRegistered(string SetName) { return default; }
	public  bool UnregisterCommandSet(string SetName) { return default; }
	public  void SetCanSetExecuteCommands(string SetName,bool bShouldExecuteCommands) {}
	public  bool CanSetExecuteCommands(string SetName) { return default; }
	public  TArray<string> GetAvailableContexts() { return default; }
	public  bool IsContextRegistered(string ContextName) { return default; }
	public  int GetBindingCountForContext(string ContextName) { return default; }
	public  bool IsInputChordMapped(string ContextName,FInputChord InputChord) { return default; }
	public static void HandleExecuteAction(FExecuteCommand OnExecuteAction,FScriptingCommandInfo CommandInfo) {}
	public  bool HandleCanExecuteAction(FCanExecuteCommand OnCanExecuteAction,FScriptingCommandInfo CommandInfo) { return default; }
	public  bool DefaultCanExecuteAction(string SetName) { return default; }
}
