#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("StageMessages.h")]
///<summary>Message sent to notify about critical state change.</summary>
public partial struct FCriticalStateProviderMessage {
// CriticalStateProviderMessage
	public EStageCriticalStateEvent State;
	public string SourceName;
}
