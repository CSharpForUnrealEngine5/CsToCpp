namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>FNodalOffsetTool is the controller for the nodal offset tool panel.</summary>
[CppInclude("AssetEditor/NodalOffsetTool.h")]
public partial class UNodalOffsetTool : UCameraCalibrationStep {
	public static UClass StaticClass() {return default;}
	///<summary>The currently selected nodal offset algorithm</summary>
	public UCameraNodalOffsetAlgo NodalOffsetAlgo;
	///<summary>Map of algo names to overlay MIDs used by those algos</summary>
	public TMap<FName,UMaterialInstanceDynamic> AlgoOverlayMIDs;
}
