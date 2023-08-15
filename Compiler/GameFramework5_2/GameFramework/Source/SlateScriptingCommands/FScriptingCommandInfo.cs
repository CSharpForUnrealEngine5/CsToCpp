namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The data defining a scripting command. At the exception of its delegates.</summary>
[CppInclude("UICommandsScriptingSubsystem.h")]
public partial struct FScriptingCommandInfo {
	public FName ContextName;
	public FName Set;
	public FName Name;
	public FText Label;
	public FText Description;
	public FInputChord InputChord;
}
