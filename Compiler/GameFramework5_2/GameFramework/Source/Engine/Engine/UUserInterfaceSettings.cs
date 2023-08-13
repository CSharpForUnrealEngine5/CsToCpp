namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>User Interface settings that control Slate and UMG.</summary>
[CppInclude("Engine/UserInterfaceSettings.h")]
public partial class UUserInterfaceSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Rule to determine if we should render the Focus Brush for widgets that have user focus.</summary>
	public ERenderFocusRule RenderFocusRule;
	///<summary>HardwareCursors</summary>
	public TMap<EMouseCursor,FHardwareCursorReference> HardwareCursors;
	///<summary>SoftwareCursors</summary>
	public TMap<EMouseCursor,FSoftClassPath> SoftwareCursors;
	///<summary>DEPRECATED 4.16</summary>
	public FSoftClassPath DefaultCursor_DEPRECATED;
	///<summary>DEPRECATED 4.16</summary>
	public FSoftClassPath TextEditBeamCursor_DEPRECATED;
	///<summary>DEPRECATED 4.16</summary>
	public FSoftClassPath CrosshairsCursor_DEPRECATED;
	///<summary>DEPRECATED 4.16</summary>
	public FSoftClassPath HandCursor_DEPRECATED;
	///<summary>DEPRECATED 4.16</summary>
	public FSoftClassPath GrabHandCursor_DEPRECATED;
	///<summary>DEPRECATED 4.16</summary>
	public FSoftClassPath GrabHandClosedCursor_DEPRECATED;
	///<summary>DEPRECATED 4.16</summary>
	public FSoftClassPath SlashedCircleCursor_DEPRECATED;
	///<summary>An optional application scale to apply on top of the custom scaling rules.  So if you want to expose a</summary>
	public float ApplicationScale;
	///<summary>The rule used when trying to decide what scale to apply.</summary>
	public EUIScalingRule UIScaleRule;
	///<summary>Set DPI Scale Rule to Custom, and this class will be used instead of any of the built-in rules.</summary>
	public FSoftClassPath CustomScalingRuleClass;
	///<summary>Controls how the UI is scaled at different resolutions based on the DPI Scale Rule</summary>
	public FRuntimeFloatCurve UIScaleCurve;
	///<summary>If true, game window on desktop platforms will be created with high-DPI awareness enabled.</summary>
	public bool bAllowHighDPIInGameMode;
	///<summary>Used only with ScaleToFit scaling rule. Defines native resolution for which were source UI textures created. DPI scaling will be 1.0 at this screen resolution.</summary>
	public FIntPoint DesignScreenSize;
	///<summary>If false, widget references will be stripped during cook for server builds and not loaded at runtime.</summary>
	public bool bLoadWidgetsOnDedicatedServer;
	///<summary>Setting to authorize or not automatic variable creation.</summary>
	public bool bAuthorizeAutomaticWidgetVariableCreation;
	///<summary>CursorClasses</summary>
	public TArray<UObject> CursorClasses;
	///<summary>CustomScalingRuleClassInstance</summary>
	public UClass CustomScalingRuleClassInstance;
	///<summary>CustomScalingRule</summary>
	public UDPICustomScalingRule CustomScalingRule;
}
