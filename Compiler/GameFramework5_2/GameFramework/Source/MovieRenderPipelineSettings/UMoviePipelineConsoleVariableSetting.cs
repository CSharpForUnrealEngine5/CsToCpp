#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MoviePipelineConsoleVariableSetting.h")]
public partial class UMoviePipelineConsoleVariableSetting : UMoviePipelineSetting {
// MoviePipelineConsoleVariableSetting
	public TArray<object /*ConsoleVariablePresets*/> ConsoleVariablePresets;
	public TMap<string,float> ConsoleVariables_DEPRECATED;
	public TArray<string> StartConsoleCommands;
	public TArray<string> EndConsoleCommands;
	public  TArray<FMoviePipelineConsoleVariableEntry> GetConsoleVariables() { return default; }
	public  bool RemoveConsoleVariable(string Name,bool bRemoveAllInstances/*=false*/) { return default; }
	public  bool AddOrUpdateConsoleVariable(string Name,float Value) { return default; }
	public  bool AddConsoleVariable(string Name,float Value) { return default; }
	public  bool UpdateConsoleVariableEnableState(string Name,bool bIsEnabled) { return default; }
	public TArray<FMoviePipelineConsoleVariableEntry> CVars;
}
