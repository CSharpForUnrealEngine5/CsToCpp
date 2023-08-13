namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NUTEnum.h")]
///<summary>Flags for configuring the minimal client, what parts of the netcode should be enabled etc.</summary>
public enum EMinClientFlags {
	None=0,
	AcceptActors=1,
	AcceptRPCs=2,
	SendRPCs=4,
	AcceptRepNotifies=8,
	SkipControlJoin=16,
	BeaconConnect=32,
	NotifyNetActors=256,
	NotifyProcessNetEvent=512,
	DumpReceivedRaw=4096,
	DumpSendRaw=8192,
	DumpReceivedRPC=16384,
	DumpSendRPC=32768,
}
