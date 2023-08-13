namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DisplayClusterConfigurationTypes_ICVFX.h")]
public partial struct FDisplayClusterConfigurationICVFX_CameraSettings {
	public bool bEnable;
	public TSoftObjectPtr<ACineCameraActor> ExternalCameraActor;
	public float BufferRatio;
	public FDisplayClusterConfigurationICVFX_CameraCustomFrustum CustomFrustum;
	public FDisplayClusterConfigurationICVFX_CameraSoftEdge SoftEdge;
	public FRotator FrustumRotation;
	public FVector FrustumOffset;
	public FDisplayClusterConfigurationICVFX_CameraBorder Border;
	public FDisplayClusterConfigurationICVFX_CameraMotionBlur CameraMotionBlur;
	public FDisplayClusterConfigurationICVFX_CameraRenderSettings RenderSettings;
	public FDisplayClusterConfigurationICVFX_ChromakeySettings Chromakey;
	public FDisplayClusterConfigurationICVFX_CameraOCIO CameraOCIO;
	public bool EnableInnerFrustumColorGrading;
	public FDisplayClusterConfigurationViewport_AllNodesColorGrading AllNodesColorGrading;
	public TArray<FDisplayClusterConfigurationViewport_PerNodeColorGrading> PerNodeColorGrading;
	public FDisplayClusterConfigurationICVFX_VisibilityList CameraHideList;
	public FDisplayClusterConfigurationClusterItemReferenceList HiddenICVFXViewports;
}
