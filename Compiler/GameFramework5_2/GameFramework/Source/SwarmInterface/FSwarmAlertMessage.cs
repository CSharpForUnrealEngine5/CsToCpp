#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SwarmMessages.h")]
public partial struct FSwarmAlertMessage {
// SwarmAlertMessage
	public FGuid JobGuid;
	public byte AlertLevel;
	public FGuid ObjectGuid;
	public int TypeId;
	public string TextMessage;
}
