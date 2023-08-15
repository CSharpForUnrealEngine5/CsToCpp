namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Message sent to notify about critical state change.</summary>
[CppInclude("StageMessages.h")]
public partial struct FCriticalStateProviderMessage {
	public EStageCriticalStateEvent State;
	public FName SourceName;
}
