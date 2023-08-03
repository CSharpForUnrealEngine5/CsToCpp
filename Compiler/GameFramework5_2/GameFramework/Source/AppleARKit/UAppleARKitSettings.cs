#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AppleARKitSettings.h")]
public partial class UAppleARKitSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>When True the project can only be installed on devices that support ARKit.</summary>
	public bool bRequireARKitSupport;
	///<summary>FaceTrackingLogDir</summary>
	public string FaceTrackingLogDir;
	///<summary>Livelink tracking type. To publish face blend shapes, or body pose data to LiveLink, or none</summary>
	public TArray<ELivelinkTrackingType> LivelinkTrackingTypes;
	///<summary>Whether file writing is enabled at all or not</summary>
	public bool bFaceTrackingLogData;
	///<summary>Whether to publish each frame or when the &quot;FaceAR WriteCurveFile</summary>
	public bool bFaceTrackingWriteEachFrame;
	///<summary>The type of face AR publisher that writes to disk to create</summary>
	public EARFaceTrackingFileWriterType FaceTrackingFileWriterType;
	///<summary>Whether to publish the camera image each frame</summary>
	public bool bShouldWriteCameraImagePerFrame;
	///<summary>The scale to write the images at. Used to reduce data footprint</summary>
	public float WrittenCameraImageScale;
	///<summary>The quality setting to generate the jpeg images at. Defaults to 85, which is &quot;high quality&quot;. Lower values reduce data footprint</summary>
	public int WrittenCameraImageQuality;
	///<summary>Defaults to none. Use Right when in portrait mode</summary>
	public ETextureRotationDirection WrittenCameraImageRotation;
	///<summary>The port to use when listening/sending LiveLink face blend shapes via the network</summary>
	public int LiveLinkPublishingPort;
	///<summary>The default name to use when publishing face tracking name</summary>
	public string DefaultFaceTrackingLiveLinkSubjectName;
	///<summary>The default name to use when publishing pose tracking name</summary>
	public string DefaultPoseTrackingLiveLinkSubjectName;
	///<summary>The default tracking to use when tracking face blend shapes (face relative or mirrored). Defaults to face relative</summary>
	public EARFaceTrackingDirection DefaultFaceTrackingDirection;
	///<summary>Whether to adjust thread priorities during an AR session or not</summary>
	public bool bAdjustThreadPrioritiesDuringARSession;
	///<summary>The game thread priority to change to when an AR session is running, default is 47</summary>
	public int GameThreadPriorityOverride;
	///<summary>The render thread priority to change to when an AR session is running, default is 45</summary>
	public int RenderThreadPriorityOverride;
	///<summary>Used to specify the timecode provider to use when identifying when an update occurred.</summary>
	public string ARKitTimecodeProvider;
}
