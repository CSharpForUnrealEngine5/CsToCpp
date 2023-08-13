namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>nDisplay in-camera VFX camera representation</summary>
[CppInclude("Components/DisplayClusterICVFXCameraComponent.h")]
public partial class UDisplayClusterICVFXCameraComponent : UCineCameraComponent {
	public static UClass StaticClass() {return default;}
	///<summary>CameraSettings</summary>
	public FDisplayClusterConfigurationICVFX_CameraSettings CameraSettings;
	///<summary>IsEnabledRef</summary>
	public FDisplayClusterEditorPropertyReference IsEnabledRef;
	///<summary>HiddenICVFXViewportsRef</summary>
	public FDisplayClusterEditorPropertyReference HiddenICVFXViewportsRef;
	///<summary>ExternalCameraActorRef</summary>
	public FDisplayClusterEditorPropertyReference ExternalCameraActorRef;
	///<summary>BufferRatioRef</summary>
	public FDisplayClusterEditorPropertyReference BufferRatioRef;
	///<summary>CustomFrustumRef</summary>
	public FDisplayClusterEditorPropertyReference CustomFrustumRef;
	///<summary>SoftEdgeRef</summary>
	public FDisplayClusterEditorPropertyReference SoftEdgeRef;
	///<summary>BorderRef</summary>
	public FDisplayClusterEditorPropertyReference BorderRef;
	///<summary>FrustumRotationRef</summary>
	public FDisplayClusterEditorPropertyReference FrustumRotationRef;
	///<summary>FrustumOffsetRef</summary>
	public FDisplayClusterEditorPropertyReference FrustumOffsetRef;
	///<summary>GenerateMipsRef</summary>
	public FDisplayClusterEditorPropertyReference GenerateMipsRef;
	///<summary>CameraMotionBlurRef</summary>
	public FDisplayClusterEditorPropertyReference CameraMotionBlurRef;
	///<summary>CameraHideListRef</summary>
	public FDisplayClusterEditorPropertyReference CameraHideListRef;
	///<summary>ChromaKeyEnabledRef</summary>
	public FDisplayClusterEditorPropertyReference ChromaKeyEnabledRef;
	///<summary>ChromakeyColorRef</summary>
	public FDisplayClusterEditorPropertyReference ChromakeyColorRef;
	///<summary>ChromakeyMarkersRef</summary>
	public FDisplayClusterEditorPropertyReference ChromakeyMarkersRef;
	///<summary>ChromakeyRenderTextureRef</summary>
	public FDisplayClusterEditorPropertyReference ChromakeyRenderTextureRef;
	///<summary>EnableInnerFrustuOCIORef</summary>
	public FDisplayClusterEditorPropertyReference EnableInnerFrustuOCIORef;
	///<summary>AllNodesOCIOConfigurationRef</summary>
	public FDisplayClusterEditorPropertyReference AllNodesOCIOConfigurationRef;
	///<summary>PerNodeOCIOProfilesRef</summary>
	public FDisplayClusterEditorPropertyReference PerNodeOCIOProfilesRef;
	///<summary>EnableInnerFrustumColorGrading</summary>
	public FDisplayClusterEditorPropertyReference EnableInnerFrustumColorGrading;
	///<summary>AllNodesColorGradingRef</summary>
	public FDisplayClusterEditorPropertyReference AllNodesColorGradingRef;
	///<summary>PerNodeColorGradingRef</summary>
	public FDisplayClusterEditorPropertyReference PerNodeColorGradingRef;
	///<summary>Set to True to replace the entire inner frustum with the specified texture.</summary>
	public FDisplayClusterEditorPropertyReference TextureReplacementEnabledRef;
	///<summary>SourceTextureRef</summary>
	public FDisplayClusterEditorPropertyReference SourceTextureRef;
	///<summary>ShouldUseTextureRegionRef</summary>
	public FDisplayClusterEditorPropertyReference ShouldUseTextureRegionRef;
	///<summary>TextureRegionRef</summary>
	public FDisplayClusterEditorPropertyReference TextureRegionRef;
	///<summary>MediaRef</summary>
	public FDisplayClusterEditorPropertyReference MediaRef;
	///<summary>RenderOrderRef</summary>
	public FDisplayClusterEditorPropertyReference RenderOrderRef;
	///<summary>CustomFrameSizeRef</summary>
	public FDisplayClusterEditorPropertyReference CustomFrameSizeRef;
	///<summary>RenderTargetRatioRef</summary>
	public FDisplayClusterEditorPropertyReference RenderTargetRatioRef;
	///<summary>GPUIndexRef</summary>
	public FDisplayClusterEditorPropertyReference GPUIndexRef;
	///<summary>StereoGPUIndexRef</summary>
	public FDisplayClusterEditorPropertyReference StereoGPUIndexRef;
	///<summary>StereoModeRef</summary>
	public FDisplayClusterEditorPropertyReference StereoModeRef;
}
