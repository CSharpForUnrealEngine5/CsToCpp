#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/UserInterfaceSettings.h")]
///<summary>User Interface settings that control Slate and UMG.</summary>
public partial class UUserInterfaceSettings : UDeveloperSettings {
// UserInterfaceSettings
	public ERenderFocusRule RenderFocusRule;
	public TMap<EMouseCursor,FHardwareCursorReference> HardwareCursors;
	public TMap<EMouseCursor,FSoftClassPath> SoftwareCursors;
	public FSoftClassPath DefaultCursor_DEPRECATED;
	public FSoftClassPath TextEditBeamCursor_DEPRECATED;
	public FSoftClassPath CrosshairsCursor_DEPRECATED;
	public FSoftClassPath HandCursor_DEPRECATED;
	public FSoftClassPath GrabHandCursor_DEPRECATED;
	public FSoftClassPath GrabHandClosedCursor_DEPRECATED;
	public FSoftClassPath SlashedCircleCursor_DEPRECATED;
	public float ApplicationScale;
	public EUIScalingRule UIScaleRule;
	public FSoftClassPath CustomScalingRuleClass;
	public FRuntimeFloatCurve UIScaleCurve;
	public bool bAllowHighDPIInGameMode;
	public FIntPoint DesignScreenSize;
	public bool bLoadWidgetsOnDedicatedServer;
	public bool bAuthorizeAutomaticWidgetVariableCreation;
	public TArray<UObject> CursorClasses;
	public UClass CustomScalingRuleClassInstance;
	public UDPICustomScalingRule CustomScalingRule;
}
