#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Commandlets/Commandlet.h")]
public partial class UCommandlet : UObject {
// Commandlet
	public string HelpDescription;
	public string HelpUsage;
	public string HelpWebLink;
	public TArray<string> HelpParamNames;
	public TArray<string> HelpParamDescriptions;
	public bool IsServer;
	public bool IsClient;
	public bool IsEditor;
	public bool LogToConsole;
	public bool ShowErrorCount;
	public bool ShowProgress;
	public bool FastExit;
}
