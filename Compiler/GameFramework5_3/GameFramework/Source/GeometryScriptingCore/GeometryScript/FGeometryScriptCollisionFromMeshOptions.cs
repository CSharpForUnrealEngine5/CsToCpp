namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/CollisionFunctions.h")]
public partial struct FGeometryScriptCollisionFromMeshOptions {
	public bool bEmitTransaction;
	public EGeometryScriptCollisionGenerationMethod Method;
	public bool bAutoDetectSpheres;
	public bool bAutoDetectBoxes;
	public bool bAutoDetectCapsules;
	public float MinThickness;
	public bool bSimplifyHulls;
	public int ConvexHullTargetFaceCount;
	public int MaxConvexHullsPerMesh;
	public float ConvexDecompositionSearchFactor;
	public float ConvexDecompositionErrorTolerance;
	public float ConvexDecompositionMinPartThickness;
	public float SweptHullSimplifyTolerance;
	public EGeometryScriptSweptHullAxis SweptHullAxis;
	public bool bRemoveFullyContainedShapes;
	public int MaxShapeCount;
}
