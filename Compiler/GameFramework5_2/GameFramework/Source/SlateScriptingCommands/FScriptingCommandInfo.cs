#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The data defining a scripting command. At the exception of its delegates.</summary>
[CppInclude("UICommandsScriptingSubsystem.h")]
public partial struct FScriptingCommandInfo {
	public string ContextName;
	public string Set;
	public string Name;
	public string Label;
	public string Description;
	public FInputChord InputChord;
}
