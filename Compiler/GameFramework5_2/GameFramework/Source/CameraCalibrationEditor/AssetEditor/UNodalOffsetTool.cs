#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AssetEditor/NodalOffsetTool.h")]
///<summary>FNodalOffsetTool is the controller for the nodal offset tool panel.</summary>
public partial class UNodalOffsetTool : UCameraCalibrationStep {
// NodalOffsetTool
	public UCameraNodalOffsetAlgo NodalOffsetAlgo;
	public TMap<string,UMaterialInstanceDynamic> AlgoOverlayMIDs;
}
