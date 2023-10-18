namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements a message for executing a console command.</summary>
[CppInclude("EngineServiceMessages.h")]
public partial struct FEngineServiceExecuteCommand {
	public string Command;
	public string UserName;
}
