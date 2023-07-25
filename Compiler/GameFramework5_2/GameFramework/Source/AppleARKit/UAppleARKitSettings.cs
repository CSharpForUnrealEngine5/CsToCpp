#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AppleARKitSettings.h")]
public partial class UAppleARKitSettings : UObject {
// AppleARKitSettings
	public bool bRequireARKitSupport;
	public string FaceTrackingLogDir;
	public TArray<ELivelinkTrackingType> LivelinkTrackingTypes;
	public bool bFaceTrackingLogData;
	public bool bFaceTrackingWriteEachFrame;
	public EARFaceTrackingFileWriterType FaceTrackingFileWriterType;
	public bool bShouldWriteCameraImagePerFrame;
	public float WrittenCameraImageScale;
	public int WrittenCameraImageQuality;
	public ETextureRotationDirection WrittenCameraImageRotation;
	public int LiveLinkPublishingPort;
	public string DefaultFaceTrackingLiveLinkSubjectName;
	public string DefaultPoseTrackingLiveLinkSubjectName;
	public EARFaceTrackingDirection DefaultFaceTrackingDirection;
	public bool bAdjustThreadPrioritiesDuringARSession;
	public int GameThreadPriorityOverride;
	public int RenderThreadPriorityOverride;
	public string ARKitTimecodeProvider;
}
