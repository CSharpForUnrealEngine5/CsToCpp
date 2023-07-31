#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings for LiveLink.</summary>
[CppInclude("LiveLinkSettings.h")]
public partial class ULiveLinkSettings : UObject {
	///<summary>DefaultRoleSettings</summary>
	public TArray<FLiveLinkRoleProjectSetting> DefaultRoleSettings;
	///<summary>The interpolation class to use for new Subjects if no specific settings we set for the Subject&#39;s role.</summary>
	public UClass FrameInterpolationProcessor;
	///<summary>The default preset that should be applied</summary>
	public TSoftObjectPtr<ULiveLinkPreset> DefaultLiveLinkPreset;
	///<summary>PresetSaveDir_DEPRECATED</summary>
	public FDirectoryPath PresetSaveDir_DEPRECATED;
	///<summary>Continuous clock offset correction step</summary>
	public float ClockOffsetCorrectionStep;
	///<summary>The default evaluation mode a source connected via the message bus should start with.</summary>
	public ELiveLinkSourceMode DefaultMessageBusSourceMode;
	///<summary>The refresh frequency of the list of message bus provider (when discovery is requested).</summary>
	public double MessageBusPingRequestFrequency;
	///<summary>The refresh frequency of the heartbeat when a provider didn&#39;t send us an updated.</summary>
	public double MessageBusHeartbeatFrequency;
	///<summary>How long we should wait before a provider become unresponsive.</summary>
	public double MessageBusHeartbeatTimeout;
	///<summary>Subjects will be removed when their source has been unresponsive for this long.</summary>
	public double MessageBusTimeBeforeRemovingInactiveSource;
	///<summary>A source may still exist but does not send frames for a subject.</summary>
	public double TimeWithoutFrameToBeConsiderAsInvalid;
	///<summary>Color for active Subjects receiving data from their Source.</summary>
	public FLinearColor ValidColor;
	///<summary>Color for Subjects that have not received data from their Source for TimeWithoutFrameToBeConsiderAsInvalid.</summary>
	public FLinearColor InvalidColor;
	///<summary>Font size of Source names shown in LiveLink Debug View.</summary>
	public byte TextSizeSource;
	///<summary>Font size of Subject names shown in LiveLink Debug View.</summary>
	public byte TextSizeSubject;
}
