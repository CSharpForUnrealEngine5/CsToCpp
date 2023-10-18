namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements a message that is published in response to FSessionServicePing.</summary>
[CppInclude("SessionServiceMessages.h")]
public partial struct FSessionServicePong {
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
