#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataprepOperations.h")]
///<summary>For each static mesh to process, replace the existing static mesh's collision setup with a convex decomposition one computed using the Hull settings</summary>
public partial class UDataprepSetConvexDecompositionCollisionOperation : UDataprepOperation {
// DataprepSetConvexDecompositionCollisionOperation
	public int HullCount;
	public int MaxHullVerts;
	public int HullPrecision;
}
