#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshRemeshFunctions.h")]
///<summary>Types of edge constraints, specified for different mesh attributes</summary>
public enum EGeometryScriptRemeshEdgeConstraintType {
	Fixed=0,
	Refine=1,
	Free=2,
	Ignore=3,
}
