namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Net/ReplayResult.h")]
public enum EReplayResult {
	Success=0,
	ReplayNotFound=1,
	Corrupt=2,
	UnsupportedCheckpoint=3,
	GameSpecific=4,
	InitConnect=5,
	LoadMap=6,
	Serialization=7,
	StreamerError=8,
	ConnectionClosed=9,
	MissingArchive=10,
	Unknown=11,
}
