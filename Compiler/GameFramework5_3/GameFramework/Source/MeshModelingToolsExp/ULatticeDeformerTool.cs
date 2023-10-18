namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Deform a mesh using a regular hexahedral lattice</summary>
[CppInclude("LatticeDeformerTool.h")]
public partial class ULatticeDeformerTool : USingleSelectionMeshEditingTool {
	public static UClass StaticClass() {return default;}
	///<summary>ControlPointsMechanic</summary>
	public ULatticeControlPointsMechanic ControlPointsMechanic;
	///<summary>Settings</summary>
	public ULatticeDeformerToolProperties Settings;
	///<summary>Preview</summary>
	public UMeshOpPreviewWithBackgroundCompute Preview;
	///<summary>bLatticeDeformed</summary>
	public bool bLatticeDeformed;
}
