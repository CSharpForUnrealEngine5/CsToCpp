#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UEditorInputSubsystem</summary>
[CppInclude("UICommandsScriptingSubsystem.h")]
public partial class UUICommandsScriptingSubsystem : UEngineSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>Registers a command within the given context and set.</summary>
	public  bool RegisterCommand(FScriptingCommandInfo CommandInfo,FExecuteCommand OnExecuteCommand,bool bOverrideExisting/*=false*/) { return default; }
	///<summary>Registers a command within the given context and set.</summary>
	public  bool RegisterCommandChecked(FScriptingCommandInfo CommandInfo,FExecuteCommand OnExecuteCommand,FCanExecuteCommand OnCanExecuteCommand,bool bOverrideExisting/*=false*/) { return default; }
	///<summary>Unregisters a command previously registered. The command name, set and context will be used for comparison.</summary>
	public  bool UnregisterCommand(FScriptingCommandInfo CommandInfo) { return default; }
	///<summary>Checks whether the given command is registered within the subsystem. Using name, set and context for comparison</summary>
	public  bool IsCommandRegistered(FScriptingCommandInfo CommandInfo,bool bCheckInputChord/*=true*/) { return default; }
	///<summary>Retrieves the list of command info for all commands currently registered in the subsystem</summary>
	public  TArray<FScriptingCommandInfo> GetRegisteredCommands() { return default; }
	///<summary>Checks whether commands registered in the subsystem can be executed</summary>
	public  bool CanExecuteCommands() { return default; }
	///<summary>Sets whether commands registered in the subsystem can be executed</summary>
	public  void SetCanExecuteCommands(bool bShouldExecuteCommands) {}
	///<summary>Unregisters all commands dynamically registered within all contexts and sets.</summary>
	public  void UnregisterAllSets() {}
	///<summary>Registers a new command set</summary>
	public  bool RegisterCommandSet(string SetName) { return default; }
	///<summary>Checks whether the given set is currently registered in the subsystem</summary>
	public  bool IsCommandSetRegistered(string SetName) { return default; }
	///<summary>Unregisters the corresponding command set with all commands registered within it</summary>
	public  bool UnregisterCommandSet(string SetName) { return default; }
	///<summary>Enables or disables execution of commands registered within the given set</summary>
	public  void SetCanSetExecuteCommands(string SetName,bool bShouldExecuteCommands) {}
	///<summary>Checks whether commands in the given set can be executed. This will also check CanExecuteCommands at a global scope</summary>
	public  bool CanSetExecuteCommands(string SetName) { return default; }
	///<summary>Retrieves the list of names for all contexts currently registered in the subsystem.</summary>
	public  TArray<string> GetAvailableContexts() { return default; }
	///<summary>Checks whether the context with the given name is currently registered in the subsystem</summary>
	public  bool IsContextRegistered(string ContextName) { return default; }
	///<summary>Retrieves the number of UI Command Lists registered within this context through the subsystem.</summary>
	public  int GetBindingCountForContext(string ContextName) { return default; }
	///<summary>Checks whether the given input chord is already mapped to a command in the given context.</summary>
	public  bool IsInputChordMapped(string ContextName,FInputChord InputChord) { return default; }
	///<summary>The delegate bound to registered commands. It will broadcast back to the given dynamic delegate</summary>
	public static void HandleExecuteAction(FExecuteCommand OnExecuteAction,FScriptingCommandInfo CommandInfo) {}
	///<summary>The delegate used to check whether a command can be executed.</summary>
	public  bool HandleCanExecuteAction(FCanExecuteCommand OnCanExecuteAction,FScriptingCommandInfo CommandInfo) { return default; }
	///<summary>The default delegate to check if a command can be executed (when the user does not provide a specific delegate).</summary>
	public  bool DefaultCanExecuteAction(string SetName) { return default; }
}
