namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DirectLinkMessages.h")]
public partial struct FDirectLinkMsg_EndpointState {
	public uint StateRevision;
	public uint MinProtocolVersion;
	public uint ProtocolVersion;
	public string UEVersion;
	public string ComputerName;
	public string UserName;
	public uint ProcessId;
	public string ExecutableName;
	public string NiceName;
	public TArray<FNamedId> Destinations;
	public TArray<FNamedId> Sources;
}
