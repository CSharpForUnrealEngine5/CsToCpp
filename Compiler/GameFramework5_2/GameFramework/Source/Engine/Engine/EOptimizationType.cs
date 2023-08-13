namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/StaticMesh.h")]
///<summary>Enum specifying the reduction type to use when simplifying static meshes.</summary>
public enum EOptimizationType {
	OT_NumOfTriangles=0,
	OT_MaxDeviation=1,
	OT_MAX=2,
}
