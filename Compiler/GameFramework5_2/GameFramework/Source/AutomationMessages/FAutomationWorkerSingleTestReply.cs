#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AutomationWorkerMessages.h")]
///<summary>A single test reply, used by FAutomationWorkerRequestTestsReplyComplete</summary>
public partial struct FAutomationWorkerSingleTestReply {
// AutomationWorkerSingleTestReply
	public string DisplayName;
	public string FullTestPath;
	public string TestName;
	public string TestParameter;
	public string SourceFile;
	public int SourceFileLine;
	public string AssetPath;
	public string OpenCommand;
	public uint TestFlags;
	public uint NumParticipantsRequired;
}
