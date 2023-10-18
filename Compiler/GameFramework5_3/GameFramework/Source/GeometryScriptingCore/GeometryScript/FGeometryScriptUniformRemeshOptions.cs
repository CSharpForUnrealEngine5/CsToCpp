namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Uniform Remeshing Options</summary>
[CppInclude("GeometryScript/MeshRemeshFunctions.h")]
public partial struct FGeometryScriptUniformRemeshOptions {
	public EGeometryScriptUniformRemeshTargetType TargetType;
	public int TargetTriangleCount;
	public float TargetEdgeLength;
}
