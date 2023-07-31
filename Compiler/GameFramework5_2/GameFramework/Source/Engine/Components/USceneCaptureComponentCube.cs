#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Used to capture a &#39;snapshot&#39; of the scene from a 6 planes and feed it to a render target.</summary>
[CppInclude("Components/SceneCaptureComponentCube.h")]
public partial class USceneCaptureComponentCube : USceneCaptureComponent {
	///<summary>Temporary render target that can be used by the editor.</summary>
	public UTextureRenderTargetCube TextureTarget;
	///<summary>Preserve the rotation of the actor when updating the capture. The default behavior is to capture the cube aligned to the world axis system.</summary>
	public bool bCaptureRotation;
	///<summary>Render the scene to the texture target immediately.</summary>
	public  void CaptureScene() {}
}
