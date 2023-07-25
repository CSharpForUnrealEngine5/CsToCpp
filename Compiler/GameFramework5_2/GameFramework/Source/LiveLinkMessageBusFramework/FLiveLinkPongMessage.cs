#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LiveLinkMessages.h")]
public partial struct FLiveLinkPongMessage {
// LiveLinkPongMessage
	public string ProviderName;
	public string MachineName;
	public FGuid PollRequest;
	public int LiveLinkVersion;
	public double CreationPlatformTime;
}
