#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Abstract base class for setting up post passes. Used in conjuntion with UComposurePostProcessingPassProxy.</summary>
[CppInclude("ComposurePostProcessingPassProxy.h")]
public partial class UComposurePostProcessPassPolicy : UObject {
	///<summary>SetupPostProcess</summary>
	public  void SetupPostProcess(USceneCaptureComponent2D SceneCapture,UMaterialInterface TonemapperOverride) {}
}
