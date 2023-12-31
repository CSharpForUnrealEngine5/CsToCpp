namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MrcCalibrationData.h")]
public partial class UMrcCalibrationData : USaveGame {
	public static UClass StaticClass() {return default;}
	///<summary>LensData</summary>
	public FMrcLensCalibrationData LensData;
	///<summary>AlignmentData</summary>
	public FMrcAlignmentSaveData AlignmentData;
	///<summary>GarbageMatteSaveDatas</summary>
	public TArray<FMrcGarbageMatteSaveData> GarbageMatteSaveDatas;
	///<summary>CompositingData</summary>
	public FMrcCompositingSaveData CompositingData;
}
