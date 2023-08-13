namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The data defining a scripting command. At the exception of its delegates.</summary>
[CppInclude("UICommandsScriptingSubsystem.h")]
public partial struct FScriptingCommandInfo {
	public string ContextName;
	public string Set;
	public string Name;
	public FText Label;
	public FText Description;
	public FInputChord InputChord;
}
