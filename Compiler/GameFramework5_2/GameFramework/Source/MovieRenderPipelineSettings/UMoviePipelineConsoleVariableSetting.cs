#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MoviePipelineConsoleVariableSetting.h")]
public partial class UMoviePipelineConsoleVariableSetting : UMoviePipelineSetting {
	///<summary>An array of presets from the Console Variables Editor. The preset cvars will be applied (in the order they are</summary>
	public TArray<object /*ConsoleVariablePresets*/> ConsoleVariablePresets;
	///<summary>ConsoleVariables_DEPRECATED</summary>
	public TMap<string,float> ConsoleVariables_DEPRECATED;
	///<summary>An array of console commands to execute when this shot is started. If you need to restore the value</summary>
	public TArray<string> StartConsoleCommands;
	///<summary>An array of console commands to execute when this shot is finished. Used to restore changes made by</summary>
	public TArray<string> EndConsoleCommands;
	///<summary>Gets a copy of all console variable overrides. These are not meant to be changed; use the mutator methods if</summary>
	public  TArray<FMoviePipelineConsoleVariableEntry> GetConsoleVariables() { return default; }
	///<summary>Removes the console variable override with the specified name. If more than one with the same name exists, the</summary>
	public  bool RemoveConsoleVariable(string Name,bool bRemoveAllInstances/*=false*/) { return default; }
	///<summary>Adds a console variable override with the given name and value if one does not already exist. If the console</summary>
	public  bool AddOrUpdateConsoleVariable(string Name,float Value) { return default; }
	///<summary>Adds a console variable override with the given name and value, and will add a duplicate if one with the provided</summary>
	public  bool AddConsoleVariable(string Name,float Value) { return default; }
	///<summary>Updates the enable state of the console variable override with the provided name. If there are duplicate cvars</summary>
	public  bool UpdateConsoleVariableEnableState(string Name,bool bIsEnabled) { return default; }
	///<summary>An array of console variable overrides which are applied during render and reverted after the render completes.</summary>
	public TArray<FMoviePipelineConsoleVariableEntry> CVars;
}
