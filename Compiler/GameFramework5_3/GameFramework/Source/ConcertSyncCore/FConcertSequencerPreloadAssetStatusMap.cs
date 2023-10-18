namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Can be sent as an event by clients to indicate loading success/failure</summary>
[CppInclude("ConcertSequencerMessages.h")]
public partial struct FConcertSequencerPreloadAssetStatusMap {
	public TMap<FTopLevelAssetPath,EConcertSequencerPreloadStatus> Sequences;
}
