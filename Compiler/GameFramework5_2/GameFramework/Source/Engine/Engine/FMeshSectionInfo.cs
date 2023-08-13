namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Per-section settings.</summary>
[CppInclude("Engine/StaticMesh.h")]
public partial struct FMeshSectionInfo {
	public int MaterialIndex;
	public bool bEnableCollision;
	public bool bCastShadow;
	public bool bVisibleInRayTracing;
	public bool bAffectDistanceFieldLighting;
	public bool bForceOpaque;
}
