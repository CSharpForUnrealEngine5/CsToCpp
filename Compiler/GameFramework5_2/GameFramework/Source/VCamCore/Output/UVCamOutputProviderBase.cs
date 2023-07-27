#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Output/VCamOutputProviderBase.h")]
public partial class UVCamOutputProviderBase : UObject {
// VCamOutputProviderBase
	public  void FActivationDelegate_Blueprint(bool bNewIsActive) {}
	public FActivationDelegate_Blueprint OnActivatedDelegate_Blueprint;
	public bool bUseOverrideResolution;
	public FIntPoint OverrideResolution;
	public  void SetActive(bool bInActive) {}
	public  bool IsActive() { return default; }
	public  bool IsInitialized() { return default; }
	public  void SetTargetCamera(UCineCameraComponent InTargetCamera) {}
	public  EVCamTargetViewportID GetTargetViewport() { return default; }
	public  void SetTargetViewport(EVCamTargetViewportID Value) {}
	public  UClass GetUMGClass() { return default; }
	public  void SetUMGClass(UClass InUMGClass) {}
	public EVPWidgetDisplayType DisplayType;
	public UGameplayViewTargetPolicy GameplayViewTargetPolicy;
	public bool bIsActive;
	public EVCamTargetViewportID TargetViewport;
	public UClass UMGClass;
	public FWidgetTreeSnapshot WidgetSnapshot;
	public bool bInitialized;
	public UVPFullScreenUserWidget UMGWidget;
	public TSoftObjectPtr<UCineCameraComponent> TargetCamera;
	public bool bWasOutputSuspendedWhileActive;
	public TSet<TWeakObjectPtr<APlayerController>> PlayersWhoseViewTargetsWereSet;
}
