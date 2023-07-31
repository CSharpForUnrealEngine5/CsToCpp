#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Graphs/GenerateStaticMeshLODProcess.h")]
///<summary>NOTE: This must be kept in sync with FMeshSimpleShapeApproximation::EProjectedHullAxisMode in MeshSimpleShapeApproximation.h</summary>
public enum EGenerateStaticMeshLODProjectedHullAxisMode {
	X=0,
	Y=1,
	Z=2,
	SmallestBoxDimension=3,
	SmallestVolume=4,
}
