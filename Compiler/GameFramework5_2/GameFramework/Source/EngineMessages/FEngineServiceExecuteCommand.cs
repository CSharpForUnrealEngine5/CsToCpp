#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements a message for executing a console command.</summary>
[CppInclude("EngineServiceMessages.h")]
public partial struct FEngineServiceExecuteCommand {
	public string Command;
	public string UserName;
}
