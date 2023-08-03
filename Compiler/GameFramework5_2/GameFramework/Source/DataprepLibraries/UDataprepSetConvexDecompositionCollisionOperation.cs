#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>For each static mesh to process, replace the existing static mesh&#39;s collision setup with a convex decomposition one computed using the Hull settings</summary>
[CppInclude("DataprepOperations.h")]
public partial class UDataprepSetConvexDecompositionCollisionOperation : UDataprepOperation {
	public static UClass StaticClass() {return default;}
	///<summary>Maximum number of convex pieces that will be created</summary>
	public int HullCount;
	///<summary>Maximum number of vertices allowed for any generated convex hulls</summary>
	public int MaxHullVerts;
	///<summary>Number of voxels to use when generating collision</summary>
	public int HullPrecision;
}
