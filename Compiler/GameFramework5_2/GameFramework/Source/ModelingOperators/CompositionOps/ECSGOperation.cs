#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CompositionOps/BooleanMeshesOp.h")]
///<summary>CSG operation types</summary>
public enum ECSGOperation {
	DifferenceAB=0,
	DifferenceBA=1,
	Intersect=2,
	Union=3,
}
