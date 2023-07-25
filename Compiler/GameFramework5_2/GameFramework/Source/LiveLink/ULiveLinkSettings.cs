#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LiveLinkSettings.h")]
///<summary>Settings for LiveLink.</summary>
public partial class ULiveLinkSettings : UObject {
// LiveLinkSettings
	public TArray<FLiveLinkRoleProjectSetting> DefaultRoleSettings;
	public UClass FrameInterpolationProcessor;
	public TSoftObjectPtr<ULiveLinkPreset> DefaultLiveLinkPreset;
	public FDirectoryPath PresetSaveDir_DEPRECATED;
	public float ClockOffsetCorrectionStep;
	public ELiveLinkSourceMode DefaultMessageBusSourceMode;
	public double MessageBusPingRequestFrequency;
	public double MessageBusHeartbeatFrequency;
	public double MessageBusHeartbeatTimeout;
	public double MessageBusTimeBeforeRemovingInactiveSource;
	public double TimeWithoutFrameToBeConsiderAsInvalid;
	public FLinearColor ValidColor;
	public FLinearColor InvalidColor;
	public byte TextSizeSource;
	public byte TextSizeSubject;
}
