namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Event indicating one or more sequences have been added or removed from the</summary>
[CppInclude("ConcertSequencerMessages.h")]
public partial struct FConcertSequencerPreloadRequest {
	public TArray<FTopLevelAssetPath> SequenceObjectPaths;
	public bool bShouldBePreloaded;
}
