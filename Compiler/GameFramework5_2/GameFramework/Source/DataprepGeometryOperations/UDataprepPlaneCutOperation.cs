#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataprepGeometryOperations.h")]
///<summary>Experimental - Plane cut input meshes</summary>
public partial class UDataprepPlaneCutOperation : UDataprepEditingOperation {
// DataprepPlaneCutOperation
	public FVector CutPlaneOrigin;
	public FVector CutPlaneNormalAngles;
	public EPlaneCutKeepSide CutPlaneKeepSide;
	public float SpacingBetweenHalves;
	public bool bFillCutHole;
	public bool bExportSeparatePieces;
}
