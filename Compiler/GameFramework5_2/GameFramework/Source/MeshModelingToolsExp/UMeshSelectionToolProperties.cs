#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MeshSelectionTool.h")]
public partial class UMeshSelectionToolProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>The Selection Mode defines the behavior of the selection brush</summary>
	public EMeshSelectionToolPrimaryMode SelectionMode;
	///<summary>Angle in Degrees used for Angle-based Selection Modes</summary>
	public float AngleTolerance;
	///<summary>Allow the brush to hit back-facing parts of the surface</summary>
	public bool bHitBackFaces;
	///<summary>Toggle drawing of highlight points on/off</summary>
	public bool bShowPoints;
	///<summary>Color each triangle based on the selected mesh attribute</summary>
	public EMeshFacesColorMode FaceColorMode;
}
