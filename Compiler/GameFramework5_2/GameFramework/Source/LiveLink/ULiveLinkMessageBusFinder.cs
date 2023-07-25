#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LiveLinkMessageBusFinder.h")]
///<summary>Asset for finding available Message Bus Sources.</summary>
public partial class ULiveLinkMessageBusFinder : UObject {
// LiveLinkMessageBusFinder
	public void GetAvailableProviders(UObject WorldContextObject,FLatentActionInfo LatentInfo,float Duration,TArray<FProviderPollResult> AvailableProviders) {}
	public void ConnectToProvider(FProviderPollResult Provider,FLiveLinkSourceHandle SourceHandle) {}
	public UObject ConstructMessageBusFinder() { return default; }
}
