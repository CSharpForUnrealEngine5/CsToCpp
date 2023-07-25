#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshRemeshFunctions.h")]
///<summary>Uniform Remeshing Options</summary>
public partial struct FGeometryScriptUniformRemeshOptions {
// GeometryScriptUniformRemeshOptions
	public EGeometryScriptUniformRemeshTargetType TargetType;
	public int TargetTriangleCount;
	public float TargetEdgeLength;
}
