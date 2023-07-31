#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/EngineBaseTypes.h")]
///<summary>Types of server travel failures broadcast by the engine</summary>
[CppEnumInNamespace]
public enum ETravelFailure {
	NoLevel=0,
	LoadMapFailure=1,
	InvalidURL=2,
	PackageMissing=3,
	PackageVersion=4,
	NoDownload=5,
	TravelFailure=6,
	CheatCommands=7,
	PendingNetGameCreateFailure=8,
	CloudSaveFailure=9,
	ServerTravelFailure=10,
	ClientTravelFailure=11,
}
