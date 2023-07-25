#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MrcCalibrationData.h")]
public partial class UMrcCalibrationData : USaveGame {
// MrcCalibrationData
	public FMrcLensCalibrationData LensData;
	public FMrcAlignmentSaveData AlignmentData;
	public TArray<FMrcGarbageMatteSaveData> GarbageMatteSaveDatas;
	public FMrcCompositingSaveData CompositingData;
}
