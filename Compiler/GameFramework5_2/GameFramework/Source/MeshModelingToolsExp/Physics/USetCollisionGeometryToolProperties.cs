#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Physics/SetCollisionGeometryTool.h")]
public partial class USetCollisionGeometryToolProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>GeometryType</summary>
	public ECollisionGeometryType GeometryType;
	///<summary>InputMode</summary>
	public ESetCollisionGeometryInputMode InputMode;
	///<summary>bUseWorldSpace</summary>
	public bool bUseWorldSpace;
	///<summary>bRemoveContained</summary>
	public bool bRemoveContained;
	///<summary>bEnableMaxCount</summary>
	public bool bEnableMaxCount;
	///<summary>MaxCount</summary>
	public int MaxCount;
	///<summary>MinThickness</summary>
	public float MinThickness;
	///<summary>bDetectBoxes</summary>
	public bool bDetectBoxes;
	///<summary>bDetectSpheres</summary>
	public bool bDetectSpheres;
	///<summary>bDetectCapsules</summary>
	public bool bDetectCapsules;
	///<summary>bSimplifyHulls</summary>
	public bool bSimplifyHulls;
	///<summary>HullTargetFaceCount</summary>
	public int HullTargetFaceCount;
	///<summary>How many convex hulls can be used to approximate each mesh</summary>
	public int MaxHullsPerMesh;
	///<summary>How much to search the space of possible decompositions beyond MaxHullsPerMesh; for larger values, will do additional work to try to better approximate mesh features (but resulting hulls may overlap more)</summary>
	public float ConvexDecompositionSearchFactor;
	///<summary>Error tolerance for adding more convex hulls, in cm.  For volumetric errors, the value will be cubed (so a value of 10 indicates a 10x10x10 volume worth of error is acceptable).</summary>
	public float AddHullsErrorTolerance;
	///<summary>Minimum part thickness for convex decomposition (in cm); hulls thinner than this will be merged into adjacent hulls, if possible.</summary>
	public float MinPartThickness;
	///<summary>bSimplifyPolygons</summary>
	public bool bSimplifyPolygons;
	///<summary>HullTolerance</summary>
	public float HullTolerance;
	///<summary>SweepAxis</summary>
	public EProjectedHullAxis SweepAxis;
	///<summary>Level set grid resolution along longest grid axis</summary>
	public int LevelSetResolution;
	///<summary>bAppendToExisting</summary>
	public bool bAppendToExisting;
	///<summary>SetCollisionType</summary>
	public ECollisionGeometryMode SetCollisionType;
}
