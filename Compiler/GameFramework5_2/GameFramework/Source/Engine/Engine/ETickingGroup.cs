#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/EngineBaseTypes.h")]
///<summary>Determines which ticking group a tick function belongs to.</summary>
public enum ETickingGroup {
	TG_PrePhysics=0,
	TG_StartPhysics=1,
	TG_DuringPhysics=2,
	TG_EndPhysics=3,
	TG_PostPhysics=4,
	TG_PostUpdateWork=5,
	TG_LastDemotable=6,
	TG_NewlySpawned=7,
	TG_MAX=8,
}
