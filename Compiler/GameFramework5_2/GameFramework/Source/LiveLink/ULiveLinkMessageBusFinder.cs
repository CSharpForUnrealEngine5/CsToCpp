#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LiveLinkMessageBusFinder.h")]
///<summary>Asset for finding available Message Bus Sources.</summary>
public partial class ULiveLinkMessageBusFinder : UObject {
// LiveLinkMessageBusFinder
	public  void GetAvailableProviders(UObject WorldContextObject,FLatentActionInfo LatentInfo,float Duration,TArray<FProviderPollResult> AvailableProviders) {}
	public static void ConnectToProvider(FProviderPollResult Provider,FLiveLinkSourceHandle SourceHandle) {}
	public static ULiveLinkMessageBusFinder ConstructMessageBusFinder() { return default; }
}
