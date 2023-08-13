namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Asset for finding available Message Bus Sources.</summary>
[CppInclude("LiveLinkMessageBusFinder.h")]
public partial class ULiveLinkMessageBusFinder : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>* Broadcasts a message to the network and returns a list of all providers who replied within a set amount of time.</summary>
	public void GetAvailableProviders(UObject WorldContextObject,FLatentActionInfo LatentInfo,float Duration,TArray<FProviderPollResult> AvailableProviders) {}
	///<summary>* Connects to a given Message Bus Provider and returns a handle to the created LiveLink Source</summary>
	public static void ConnectToProvider(FProviderPollResult Provider,FLiveLinkSourceHandle SourceHandle) {}
	///<summary>* Constructs a new Message Bus Finder which enables you to detect available Message Bus Providers on the network</summary>
	public static ULiveLinkMessageBusFinder ConstructMessageBusFinder() { return default; }
}
