namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Experimental - Plane cut input meshes</summary>
[CppInclude("DataprepGeometryOperations.h")]
public partial class UDataprepPlaneCutOperation : UDataprepEditingOperation {
	public static UClass StaticClass() {return default;}
	///<summary>Origin of the cutting plane</summary>
	public FVector CutPlaneOrigin;
	///<summary>Euler angles of the normal to the cutting plane (default plane is XY plane)</summary>
	public FVector CutPlaneNormalAngles;
	///<summary>Specify which section(s) of the cut to keep. If &#39;Keep Both&#39; is selected, both sides of the</summary>
	public EPlaneCutKeepSide CutPlaneKeepSide;
	///<summary>If keeping both halves, separate the two pieces by this amount</summary>
	public float SpacingBetweenHalves;
	///<summary>If true, the cut surface is filled with simple planar hole fill surface(s)</summary>
	public bool bFillCutHole;
	///<summary>If true, meshes cut into multiple pieces will be saved as separate assets.</summary>
	public bool bExportSeparatePieces;
}
