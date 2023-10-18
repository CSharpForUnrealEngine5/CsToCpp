namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Sent as an event by server with preload status of one or more clients.</summary>
[CppInclude("ConcertSequencerMessages.h")]
public partial struct FConcertSequencerPreloadClientStatusMap {
	public TMap<FGuid,FConcertSequencerPreloadAssetStatusMap> ClientEndpoints;
}
