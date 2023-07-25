#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LatticeDeformerTool.h")]
///<summary>Deform a mesh using a regular hexahedral lattice</summary>
public partial class ULatticeDeformerTool : USingleSelectionMeshEditingTool {
// LatticeDeformerTool
	public ULatticeControlPointsMechanic ControlPointsMechanic;
	public ULatticeDeformerToolProperties Settings;
	public UMeshOpPreviewWithBackgroundCompute Preview;
	public bool bLatticeDeformed;
}
