namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Abstract base class for setting up post passes. Used in conjuntion with UComposurePostProcessingPassProxy.</summary>
[CppInclude("ComposurePostProcessingPassProxy.h")]
public partial class UComposurePostProcessPassPolicy : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>SetupPostProcess</summary>
	public void SetupPostProcess(USceneCaptureComponent2D SceneCapture,UMaterialInterface TonemapperOverride) {}
}
