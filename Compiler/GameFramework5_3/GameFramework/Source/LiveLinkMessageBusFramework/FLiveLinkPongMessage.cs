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
