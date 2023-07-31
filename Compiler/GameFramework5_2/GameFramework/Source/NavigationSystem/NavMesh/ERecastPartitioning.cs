#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NavMesh/RecastNavMesh.h")]
///<summary>keep in sync with rcRegionPartitioning enum!</summary>
[CppEnumInNamespace]
public enum ERecastPartitioning {
	Monotone=0,
	Watershed=1,
	ChunkyMonotone=2,
}
