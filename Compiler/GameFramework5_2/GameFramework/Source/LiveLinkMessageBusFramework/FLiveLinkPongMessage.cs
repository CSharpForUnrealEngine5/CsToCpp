#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LiveLinkMessages.h")]
public partial struct FLiveLinkPongMessage {
	public string ProviderName;
	public string MachineName;
	public FGuid PollRequest;
	public int LiveLinkVersion;
	public double CreationPlatformTime;
}
