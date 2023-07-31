#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MrcCalibrationData.h")]
public partial class UMrcCalibrationData : USaveGame {
	///<summary>LensData</summary>
	public FMrcLensCalibrationData LensData;
	///<summary>AlignmentData</summary>
	public FMrcAlignmentSaveData AlignmentData;
	///<summary>GarbageMatteSaveDatas</summary>
	public TArray<FMrcGarbageMatteSaveData> GarbageMatteSaveDatas;
	///<summary>CompositingData</summary>
	public FMrcCompositingSaveData CompositingData;
}
