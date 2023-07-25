#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UICommandsScriptingSubsystem.h")]
///<summary>The data defining a scripting command. At the exception of its delegates.</summary>
public partial struct FScriptingCommandInfo {
// ScriptingCommandInfo
	public string ContextName;
	public string Set;
	public string Name;
	public string Label;
	public string Description;
	public FInputChord InputChord;
}
