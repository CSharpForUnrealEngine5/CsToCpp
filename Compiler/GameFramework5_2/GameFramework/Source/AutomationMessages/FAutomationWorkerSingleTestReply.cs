namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A single test reply, used by FAutomationWorkerRequestTestsReplyComplete</summary>
[CppInclude("AutomationWorkerMessages.h")]
public partial struct FAutomationWorkerSingleTestReply {
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
