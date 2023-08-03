#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>ULensInfoStep is used as the initial step to provide information about the lens you are going to calibrate</summary>
[CppInclude("AssetEditor/LensInfoStep.h")]
public partial class ULensInfoStep : UCameraCalibrationStep {
	public static UClass StaticClass() {return default;}
	///<summary>Cached previous LensInfo, used to trigger correct transactions to allow for undo operations</summary>
	public FLensInfo CachedLensInfo;
}
