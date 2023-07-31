#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Structure for defining an external tool</summary>
[CppInclude("Tests/AutomationTestSettings.h")]
public partial struct FExternalToolDefinition {
	public string ToolName;
	public FFilePath ExecutablePath;
	public string CommandLineOptions;
	public FDirectoryPath WorkingDirectory;
	public string ScriptExtension;
	public FDirectoryPath ScriptDirectory;
}
