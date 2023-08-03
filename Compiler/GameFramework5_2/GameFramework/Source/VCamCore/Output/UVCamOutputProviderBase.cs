#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Output/VCamOutputProviderBase.h")]
public partial class UVCamOutputProviderBase : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>FActivationDelegate_Blueprint</summary>
	public  void FActivationDelegate_Blueprint(bool bNewIsActive) {}
	///<summary>Called when the activation state of this output provider changes.</summary>
	public FActivationDelegate_Blueprint OnActivatedDelegate_Blueprint;
	///<summary>Override the default output resolution with a custom value - NOTE you must toggle bIsActive off then back on for this to take effect</summary>
	public bool bUseOverrideResolution;
	///<summary>When bUseOverrideResolution is set, use this custom resolution</summary>
	public FIntPoint OverrideResolution;
	///<summary>Called to turn on or off this output provider</summary>
	public  void SetActive(bool bInActive) {}
	///<summary>Returns if this output provider is currently active or not</summary>
	public  bool IsActive() { return default; }
	///<summary>Returns if this output provider has been initialized or not</summary>
	public  bool IsInitialized() { return default; }
	///<summary>SetTargetCamera</summary>
	public  void SetTargetCamera(UCineCameraComponent InTargetCamera) {}
	///<summary>GetTargetViewport</summary>
	public  EVCamTargetViewportID GetTargetViewport() { return default; }
	///<summary>SetTargetViewport</summary>
	public  void SetTargetViewport(EVCamTargetViewportID Value) {}
	///<summary>GetUMGClass</summary>
	public  UClass GetUMGClass() { return default; }
	///<summary>SetUMGClass</summary>
	public  void SetUMGClass(UClass InUMGClass) {}
	///<summary>Defines how the overlay widget should be added to the viewport. This should as early as possible: in  the constructor.</summary>
	public EVPWidgetDisplayType DisplayType;
	///<summary>In game worlds, such as PIE or shipped games, determines which a player controller whose view target should be set to the owning cine camera.</summary>
	public UGameplayViewTargetPolicy GameplayViewTargetPolicy;
	///<summary>If set, this output provider will execute every frame</summary>
	public bool bIsActive;
	///<summary>Which viewport to use for this VCam</summary>
	public EVCamTargetViewportID TargetViewport;
	///<summary>The UMG class to be rendered in this output provider</summary>
	public UClass UMGClass;
	///<summary>FOutputProviderLayoutCustomization allows remapping connections and their bound widgets. This is used to persist those overrides since UUserWidgets cannot be saved.</summary>
	public FWidgetTreeSnapshot WidgetSnapshot;
	///<summary>bInitialized</summary>
	public bool bInitialized;
	///<summary>Valid when active and if UMGClass is valid.</summary>
	public UVPFullScreenUserWidget UMGWidget;
	///<summary>TargetCamera</summary>
	public TSoftObjectPtr<UCineCameraComponent> TargetCamera;
	///<summary>SuspendOutput can disable output while we&#39;re active. This flag indicates whether we should reactivate when RestoreOutput is called.</summary>
	public bool bWasOutputSuspendedWhileActive;
	///<summary>If in a game world, these player controllers must have their view targets reverted when this output provider is deactivated.</summary>
	public TSet<TWeakObjectPtr<APlayerController>> PlayersWhoseViewTargetsWereSet;
}
