#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/NetConnection.h")]
public partial class UNetConnection : UPlayer {
// NetConnection
	public TArray<UChildConnection> Children;
	public UNetDriver Driver;
	public UClass PackageMapClass;
	public UPackageMap PackageMap;
	public TArray<UChannel> OpenChannels;
	public TArray<AActor> SentTemporaries;
	public AActor ViewTarget;
	public AActor OwningActor;
	public int MaxPacket;
	public bool InternalAck;
	public FUniqueNetIdRepl PlayerId;
	public double LastReceiveTime;
	public int DefaultMaxChannelSize;
	public TArray<UChannel> ChannelsToTick;
}
