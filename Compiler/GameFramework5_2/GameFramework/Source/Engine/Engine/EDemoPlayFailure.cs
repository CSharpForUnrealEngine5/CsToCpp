#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/EngineBaseTypes.h")]
///<summary>Types of demo play failures broadcast from the engine</summary>
public enum EDemoPlayFailure {
	Generic=0,
	DemoNotFound=1,
	Corrupt=2,
	InvalidVersion=3,
	InitBase=4,
	GameSpecificHeader=5,
	ReplayStreamerInternal=6,
	LoadMap=7,
	Serialization=8,
}
