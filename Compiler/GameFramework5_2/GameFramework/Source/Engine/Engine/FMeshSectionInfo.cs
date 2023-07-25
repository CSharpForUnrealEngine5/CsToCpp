#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/StaticMesh.h")]
///<summary>Per-section settings.</summary>
public partial struct FMeshSectionInfo {
// MeshSectionInfo
	public int MaterialIndex;
	public bool bEnableCollision;
	public bool bCastShadow;
	public bool bVisibleInRayTracing;
	public bool bAffectDistanceFieldLighting;
	public bool bForceOpaque;
}
