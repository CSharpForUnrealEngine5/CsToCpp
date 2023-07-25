#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Physics/SetCollisionGeometryTool.h")]
public partial class USetCollisionGeometryToolProperties : UInteractiveToolPropertySet {
// SetCollisionGeometryToolProperties
	public ECollisionGeometryType GeometryType;
	public ESetCollisionGeometryInputMode InputMode;
	public bool bUseWorldSpace;
	public bool bRemoveContained;
	public bool bEnableMaxCount;
	public int MaxCount;
	public float MinThickness;
	public bool bDetectBoxes;
	public bool bDetectSpheres;
	public bool bDetectCapsules;
	public bool bSimplifyHulls;
	public int HullTargetFaceCount;
	public int MaxHullsPerMesh;
	public float ConvexDecompositionSearchFactor;
	public float AddHullsErrorTolerance;
	public float MinPartThickness;
	public bool bSimplifyPolygons;
	public float HullTolerance;
	public EProjectedHullAxis SweepAxis;
	public int LevelSetResolution;
	public bool bAppendToExisting;
	public ECollisionGeometryMode SetCollisionType;
}
