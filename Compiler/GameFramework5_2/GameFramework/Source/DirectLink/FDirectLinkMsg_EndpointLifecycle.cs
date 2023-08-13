namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>namespace DirectLink</summary>
[CppInclude("DirectLinkMessages.h")]
public partial struct FDirectLinkMsg_EndpointLifecycle {
	public byte LifecycleState;
	public uint EndpointStateRevision;
}
