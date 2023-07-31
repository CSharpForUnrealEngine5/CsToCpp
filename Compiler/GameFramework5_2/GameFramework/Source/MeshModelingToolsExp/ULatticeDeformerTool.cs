#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Deform a mesh using a regular hexahedral lattice</summary>
[CppInclude("LatticeDeformerTool.h")]
public partial class ULatticeDeformerTool : USingleSelectionMeshEditingTool {
	///<summary>ControlPointsMechanic</summary>
	public ULatticeControlPointsMechanic ControlPointsMechanic;
	///<summary>Settings</summary>
	public ULatticeDeformerToolProperties Settings;
	///<summary>Preview</summary>
	public UMeshOpPreviewWithBackgroundCompute Preview;
	///<summary>bLatticeDeformed</summary>
	public bool bLatticeDeformed;
}
