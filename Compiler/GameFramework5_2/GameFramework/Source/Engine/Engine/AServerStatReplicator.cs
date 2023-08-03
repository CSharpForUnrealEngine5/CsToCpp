#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Class used to replicate server &quot;stat net&quot; data over. For server only values, the client data is</summary>
[CppInclude("Engine/ServerStatReplicator.h")]
public partial class AServerStatReplicator : AInfo {
	public static UClass StaticClass() {return default;}
	///<summary>Whether to update stat net with data from the server or not</summary>
	public bool bUpdateStatNet;
	///<summary>Whether to overwrite client data stat net with data from the server or not</summary>
	public bool bOverwriteClientStats;
	///<summary>See: Network stats counters in EngineStats.h</summary>
	public uint Channels;
	///<summary>See: Network stats counters in EngineStats.h</summary>
	public uint InRate;
	///<summary>See: Network stats counters in EngineStats.h</summary>
	public uint OutRate;
	///<summary>See: Network stats counters in EngineStats.h</summary>
	public uint MaxPacketOverhead;
	///<summary>See: Network stats counters in EngineStats.h</summary>
	public uint InRateClientMax;
	///<summary>See: Network stats counters in EngineStats.h</summary>
	public uint InRateClientMin;
	///<summary>See: Network stats counters in EngineStats.h</summary>
	public uint InRateClientAvg;
	///<summary>See: Network stats counters in EngineStats.h</summary>
	public uint InPacketsClientMax;
	///<summary>See: Network stats counters in EngineStats.h</summary>
	public uint InPacketsClientMin;
	///<summary>See: Network stats counters in EngineStats.h</summary>
	public uint InPacketsClientAvg;
	///<summary>See: Network stats counters in EngineStats.h</summary>
	public uint OutRateClientMax;
	///<summary>See: Network stats counters in EngineStats.h</summary>
	public uint OutRateClientMin;
	///<summary>See: Network stats counters in EngineStats.h</summary>
	public uint OutRateClientAvg;
	///<summary>See: Network stats counters in EngineStats.h</summary>
	public uint OutPacketsClientMax;
	///<summary>See: Network stats counters in EngineStats.h</summary>
	public uint OutPacketsClientMin;
	///<summary>See: Network stats counters in EngineStats.h</summary>
	public uint OutPacketsClientAvg;
	///<summary>See: Network stats counters in EngineStats.h</summary>
	public uint NetNumClients;
	///<summary>See: Network stats counters in EngineStats.h</summary>
	public uint InPackets;
	///<summary>See: Network stats counters in EngineStats.h</summary>
	public uint OutPackets;
	///<summary>See: Network stats counters in EngineStats.h</summary>
	public uint InBunches;
	///<summary>See: Network stats counters in EngineStats.h</summary>
	public uint OutBunches;
	///<summary>See: Network stats counters in EngineStats.h</summary>
	public uint OutLoss;
	///<summary>See: Network stats counters in EngineStats.h</summary>
	public uint InLoss;
	///<summary>See: Network stats counters in EngineStats.h</summary>
	public uint VoiceBytesSent;
	///<summary>See: Network stats counters in EngineStats.h</summary>
	public uint VoiceBytesRecv;
	///<summary>See: Network stats counters in EngineStats.h</summary>
	public uint VoicePacketsSent;
	///<summary>See: Network stats counters in EngineStats.h</summary>
	public uint VoicePacketsRecv;
	///<summary>See: Network stats counters in EngineStats.h</summary>
	public uint PercentInVoice;
	///<summary>See: Network stats counters in EngineStats.h</summary>
	public uint PercentOutVoice;
	///<summary>See: Network stats counters in EngineStats.h</summary>
	public uint NumActorChannels;
	///<summary>See: Network stats counters in EngineStats.h</summary>
	public uint NumConsideredActors;
	///<summary>See: Network stats counters in EngineStats.h</summary>
	public uint PrioritizedActors;
	///<summary>See: Network stats counters in EngineStats.h</summary>
	public uint NumRelevantActors;
	///<summary>See: Network stats counters in EngineStats.h</summary>
	public uint NumRelevantDeletedActors;
	///<summary>See: Network stats counters in EngineStats.h</summary>
	public uint NumReplicatedActorAttempts;
	///<summary>See: Network stats counters in EngineStats.h</summary>
	public uint NumReplicatedActors;
	///<summary>See: Network stats counters in EngineStats.h</summary>
	public uint NumActors;
	///<summary>See: Network stats counters in EngineStats.h</summary>
	public uint NumNetActors;
	///<summary>See: Network stats counters in EngineStats.h</summary>
	public uint NumDormantActors;
	///<summary>See: Network stats counters in EngineStats.h</summary>
	public uint NumInitiallyDormantActors;
	///<summary>See: Network stats counters in EngineStats.h</summary>
	public uint NumNetGUIDsAckd;
	///<summary>See: Network stats counters in EngineStats.h</summary>
	public uint NumNetGUIDsPending;
	///<summary>See: Network stats counters in EngineStats.h</summary>
	public uint NumNetGUIDsUnAckd;
	///<summary>See: Network stats counters in EngineStats.h</summary>
	public uint ObjPathBytes;
	///<summary>See: Network stats counters in EngineStats.h</summary>
	public uint NetGUIDOutRate;
	///<summary>See: Network stats counters in EngineStats.h</summary>
	public uint NetGUIDInRate;
	///<summary>See: Network stats counters in EngineStats.h</summary>
	public uint NetSaturated;
}
