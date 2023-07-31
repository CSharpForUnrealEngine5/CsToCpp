#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Graphs/GenerateStaticMeshLODProcess.h")]
public partial struct FGenerateStaticMeshLODProcess_CollisionSettings {
	public string CollisionGroupLayerName;
	public EGenerateStaticMeshLODSimpleCollisionGeometryType CollisionType;
	public int ConvexTriangleCount;
	public bool bPrefilterVertices;
	public int PrefilterGridResolution;
	public bool bSimplifyPolygons;
	public float HullTolerance;
	public EGenerateStaticMeshLODProjectedHullAxisMode SweepAxis;
}
