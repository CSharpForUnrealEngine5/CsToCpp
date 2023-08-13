namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SwarmMessages.h")]
public partial struct FSwarmAlertMessage {
	public FGuid JobGuid;
	public byte AlertLevel;
	public FGuid ObjectGuid;
	public int TypeId;
	public string TextMessage;
}
