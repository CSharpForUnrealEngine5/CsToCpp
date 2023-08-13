namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/NetConnection.h")]
public partial class UNetConnection : UPlayer {
	public static UClass StaticClass() {return default;}
	///<summary>child connections for secondary viewports</summary>
	public TArray<UChildConnection> Children;
	///<summary>Owning net driver</summary>
	public UNetDriver Driver;
	///<summary>The class name for the PackageMap to be loaded</summary>
	public UClass PackageMapClass;
	///<summary>Package map between local and remote. (negotiates net serialization)</summary>
	public UPackageMap PackageMap;
	///<summary>@todo document</summary>
	public TArray<UChannel> OpenChannels;
	///<summary>This actor is bNetTemporary, which means it should never be replicated after it&#39;s initial packet is complete</summary>
	public TArray<AActor> SentTemporaries;
	///<summary>The actor that is currently being viewed/controlled by the owning controller</summary>
	public AActor ViewTarget;
	///<summary>Reference to controlling actor (usually PlayerController)</summary>
	public AActor OwningActor;
	///<summary>MaxPacket</summary>
	public int MaxPacket;
	///<summary>InternalAck</summary>
	public bool InternalAck;
	///<summary>Net id of remote player on this connection. Only valid on client connections (server side).</summary>
	public FUniqueNetIdRepl PlayerId;
	///<summary>Internal.</summary>
	public double LastReceiveTime;
	///<summary>Channel table.</summary>
	public int DefaultMaxChannelSize;
	///<summary>The channels that need ticking. This will be a subset of OpenChannels, only including</summary>
	public TArray<UChannel> ChannelsToTick;
}
