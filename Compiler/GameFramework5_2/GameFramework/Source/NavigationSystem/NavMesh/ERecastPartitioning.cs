#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NavMesh/RecastNavMesh.h")]
///<summary>keep in sync with rcRegionPartitioning enum!</summary>
public enum ERecastPartitioning {
	Monotone=0,
	Watershed=1,
	ChunkyMonotone=2,
}
