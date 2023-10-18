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
