#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tests/AutomationTestSettings.h")]
///<summary>Structure for defining an external tool</summary>
public partial struct FExternalToolDefinition {
// ExternalToolDefinition
	public string ToolName;
	public FFilePath ExecutablePath;
	public string CommandLineOptions;
	public FDirectoryPath WorkingDirectory;
	public string ScriptExtension;
	public FDirectoryPath ScriptDirectory;
}
