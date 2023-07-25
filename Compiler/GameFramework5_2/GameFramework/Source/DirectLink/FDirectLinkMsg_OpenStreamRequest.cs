#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DirectLinkMessages.h")]
public partial struct FDirectLinkMsg_OpenStreamRequest {
// DirectLinkMsg_OpenStreamRequest
	public bool bRequestFromSource;
	public int RequestFromStreamPort;
	public FGuid SourceGuid;
	public FGuid DestinationGuid;
}
