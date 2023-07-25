#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/SceneCaptureComponentCube.h")]
///<summary>Used to capture a 'snapshot' of the scene from a 6 planes and feed it to a render target.</summary>
public partial class USceneCaptureComponentCube : USceneCaptureComponent {
// SceneCaptureComponentCube
	public UTextureRenderTargetCube TextureTarget;
	public bool bCaptureRotation;
	public void CaptureScene() {}
}
