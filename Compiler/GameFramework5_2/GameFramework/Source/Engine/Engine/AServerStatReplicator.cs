#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/ServerStatReplicator.h")]
///<summary>Class used to replicate server "stat net" data over. For server only values, the client data is</summary>
public partial class AServerStatReplicator : AInfo {
// ServerStatReplicator
	public bool bUpdateStatNet;
	public bool bOverwriteClientStats;
	public uint Channels;
	public uint InRate;
	public uint OutRate;
	public uint MaxPacketOverhead;
	public uint InRateClientMax;
	public uint InRateClientMin;
	public uint InRateClientAvg;
	public uint InPacketsClientMax;
	public uint InPacketsClientMin;
	public uint InPacketsClientAvg;
	public uint OutRateClientMax;
	public uint OutRateClientMin;
	public uint OutRateClientAvg;
	public uint OutPacketsClientMax;
	public uint OutPacketsClientMin;
	public uint OutPacketsClientAvg;
	public uint NetNumClients;
	public uint InPackets;
	public uint OutPackets;
	public uint InBunches;
	public uint OutBunches;
	public uint OutLoss;
	public uint InLoss;
	public uint VoiceBytesSent;
	public uint VoiceBytesRecv;
	public uint VoicePacketsSent;
	public uint VoicePacketsRecv;
	public uint PercentInVoice;
	public uint PercentOutVoice;
	public uint NumActorChannels;
	public uint NumConsideredActors;
	public uint PrioritizedActors;
	public uint NumRelevantActors;
	public uint NumRelevantDeletedActors;
	public uint NumReplicatedActorAttempts;
	public uint NumReplicatedActors;
	public uint NumActors;
	public uint NumNetActors;
	public uint NumDormantActors;
	public uint NumInitiallyDormantActors;
	public uint NumNetGUIDsAckd;
	public uint NumNetGUIDsPending;
	public uint NumNetGUIDsUnAckd;
	public uint ObjPathBytes;
	public uint NetGUIDOutRate;
	public uint NetGUIDInRate;
	public uint NetSaturated;
}
