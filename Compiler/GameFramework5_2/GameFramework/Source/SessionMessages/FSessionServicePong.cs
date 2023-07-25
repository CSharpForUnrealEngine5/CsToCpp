#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SessionServiceMessages.h")]
///<summary>Implements a message that is published in response to FSessionServicePing.</summary>
public partial struct FSessionServicePong {
// SessionServicePong
	public bool Authorized;
	public string BuildDate;
	public string DeviceName;
	public FGuid InstanceId;
	public string InstanceName;
	public string PlatformName;
	public FGuid SessionId;
	public string SessionName;
	public string SessionOwner;
	public bool Standalone;
}
