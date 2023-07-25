#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ComposurePostProcessingPassProxy.h")]
///<summary>Abstract base class for setting up post passes. Used in conjuntion with UComposurePostProcessingPassProxy.</summary>
public partial class UComposurePostProcessPassPolicy : UObject {
// ComposurePostProcessPassPolicy
	public void SetupPostProcess(UObject SceneCapture,UObject TonemapperOverride) {}
}
