#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SceneQueries/SceneSnappingManager.h")]
///<summary>Types of Snap Targets that a caller may want to run snap queries against.</summary>
public enum ESceneSnapQueryTargetType {
	None=0,
	MeshVertex=1,
	MeshEdge=2,
	Grid=4,
	All=-1,
}
