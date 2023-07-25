#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/MeshMerging.h")]
///<summary>Enum specifying the reduction type to use when simplifying static meshes with the engines internal tool</summary>
public enum EStaticMeshReductionTerimationCriterion {
	Triangles=0,
	Vertices=1,
	Any=2,
}
