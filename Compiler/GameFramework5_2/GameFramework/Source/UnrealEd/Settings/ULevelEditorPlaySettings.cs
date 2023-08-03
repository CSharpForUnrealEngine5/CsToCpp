#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements the Editor&#39;s play settings.</summary>
[CppInclude("Settings/LevelEditorPlaySettings.h")]
public partial class ULevelEditorPlaySettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The PlayerStart class used when spawning the player at the current camera location.</summary>
	public string PlayFromHerePlayerStartClassName;
	///<summary>Give the game mouse control when PIE starts or require a click in the viewport first</summary>
	public bool GameGetsMouseControl;
	///<summary>While using the game viewport, it sends mouse movement and clicks as touch events, instead of as mouse events.</summary>
	public bool UseMouseForTouch;
	///<summary>Whether to show a label for mouse control gestures in the PIE view.</summary>
	public bool ShowMouseControlLabel;
	///<summary>Location on screen to anchor the mouse control label when in PIE mode.</summary>
	public ELabelAnchorMode MouseControlLabelPosition;
	///<summary>Whether or not HMD orientation should be used when playing in viewport</summary>
	public bool ViewportGetsHMDControl;
	///<summary>Whether or not the editor is minimized on VR PIE</summary>
	public bool ShouldMinimizeEditorOnVRPIE;
	///<summary>Whether or not the editor is minimized on non-VR PIE</summary>
	public bool bShouldMinimizeEditorOnNonVRPIE;
	///<summary>Whether we should emulate stereo (helps checking VR rendering issues).</summary>
	public bool bEmulateStereo;
	///<summary>Automatically recompile blueprints used by the current level when initiating a Play In Editor session</summary>
	public bool AutoRecompileBlueprints;
	///<summary>Whether to play sounds when in a Play In Editor session</summary>
	public bool EnableGameSound;
	///<summary>Whether to automatically solo audio in first PIE client</summary>
	public bool SoloAudioInFirstPIEClient;
	///<summary>Whether to play a sound when entering and exiting PIE</summary>
	public bool EnablePIEEnterAndExitSounds;
	///<summary>Which quality level to use when playing in editor</summary>
	public int PlayInEditorSoundQualityLevel;
	///<summary>Whether to use a non-realtime audio device during PIE</summary>
	public bool bUseNonRealtimeAudioDevice;
	///<summary>True if Play In Editor should only load currently-visible levels in PIE.</summary>
	public bool bOnlyLoadVisibleLevelsInPIE;
	///<summary>Prefer to stream sub-levels from the disk instead of duplicating editor sub-levels</summary>
	public bool bPreferToStreamLevelsInPIE;
	///<summary>Should warnings and errors in the Output Log during &quot;Play in Editor&quot; be promoted to the message log?</summary>
	public bool bPromoteOutputLogWarningsDuringPIE;
	///<summary>The width of the new view port window in pixels (0 = use the desktop&#39;s screen resolution).</summary>
	public int NewWindowWidth;
	///<summary>The height of the new view port window in pixels (0 = use the desktop&#39;s screen resolution).</summary>
	public int NewWindowHeight;
	///<summary>The position of the new view port window on the screen in pixels.</summary>
	public FIntPoint NewWindowPosition;
	///<summary>Whether the new window should be centered on the screen.</summary>
	public bool CenterNewWindow;
	///<summary>Always have the PIE window on top of the parent windows.</summary>
	public bool PIEAlwaysOnTop;
	///<summary>Whether sound should be disabled when playing standalone games.</summary>
	public bool DisableStandaloneSound;
	///<summary>Extra parameters to be include as part of the command line for the standalone game.</summary>
	public string AdditionalLaunchParameters;
	///<summary>Whether to build the game before launching on device.</summary>
	public EPlayOnBuildMode BuildGameBeforeLaunch;
	///<summary>Which build configuration to use when launching on device.</summary>
	public EPlayOnLaunchConfiguration LaunchConfiguration;
	///<summary>Whether to content should be stored in pak files when launching on device. */</summary>
	public EPlayOnPakFileMode PackFilesForLaunch;
	///<summary>Whether to automatically recompile dirty Blueprints before launching</summary>
	public bool bAutoCompileBlueprintsOnLaunch;
	///<summary>This is a rarely used option that will launch a separate server (possibly hidden in-process depending on RunUnderOneProcess)</summary>
	public bool bLaunchSeparateServer;
	///<summary>NetMode to use for Play In Editor.</summary>
	public EPlayNetMode PlayNetMode;
	///<summary>Spawn multiple player windows in a single instance of UE. This will load much faster, but has potential to have more issues.</summary>
	public bool RunUnderOneProcess;
	///<summary>PlayNetDedicated</summary>
	public bool PlayNetDedicated;
	///<summary>The number of client windows to open. The first one to open will respect the Play In Editor &quot;Modes&quot; option (PIE, PINW), additional clients respect the RunUnderOneProcess setting.</summary>
	public int PlayNumberOfClients;
	///<summary>In multiplayer PIE which client will be the &#39;primary&#39;. Considered most important and given a larger client window, access to unique hardware like a VirtualReality HMD, etc. Intended to help test issues that affect the second, etc client.  0 is the first client. If the setting is &gt;= than the number of clients the last will be primary. -1 will result in no primary.  Note that this is an index only of PIE instance windows, in netmode &#39;Play as Client&#39; pie instance zero is a windowless dedicated server, so setting 0 here would make the fist pie window the primary which would be PIEInstance 1, rather than 0 as in other netmodes.</summary>
	public int PrimaryPIEClientIndex;
	///<summary>What port used by the server for simple networking</summary>
	public ushort ServerPort;
	///<summary>Width to use when spawning additional windows.</summary>
	public int ClientWindowWidth;
	///<summary>AutoConnectToServer</summary>
	public bool AutoConnectToServer;
	///<summary>When running multiple player windows in a single process, this option determines how the game pad input gets routed.</summary>
	public bool RouteGamepadToSecondWindow;
	///<summary>If checked, a separate audio device is created for every player.</summary>
	public bool CreateAudioDeviceForEveryPlayer;
	///<summary>Height to use when spawning additional windows.</summary>
	public int ClientWindowHeight;
	///<summary>Override the map launched by the dedicated server (currently only used when in PIE_StandaloneWithServer net mode)</summary>
	public string ServerMapNameOverride;
	///<summary>Additional options that will be passed to the server as URL parameters, in the format ?bIsLanMatch=1?listen - any additional command line switches should be passed in the Additional Server Launch Parameters field below.</summary>
	public string AdditionalServerGameOptions;
	///<summary>AdditionalLaunchOptions</summary>
	public string AdditionalLaunchOptions;
	///<summary>Controls the default value of the show flag ServerDrawDebug</summary>
	public bool bShowServerDebugDrawingByDefault;
	///<summary>How strongly debug drawing originating from the server will be biased towards the tint color</summary>
	public float ServerDebugDrawingColorTintStrength;
	///<summary>Debug drawing originating from the server will be biased towards this color</summary>
	public FLinearColor ServerDebugDrawingColorTint;
	///<summary>Additional options that will be passed to the server as arguments, for example -debug. Only works with separate process servers.</summary>
	public string AdditionalServerLaunchParameters;
	///<summary>If &gt; 0, Tick dedicated server at a fixed frame rate. Does not impact Listen Server (use ClientFixedFPS setting). This is the target frame rate, e.g, &quot;20&quot; for 20fps, which will result in 1/20 second tick steps.</summary>
	public int ServerFixedFPS;
	///<summary>If &gt; 0, Tick clients at a fixed frame rate. Each client instance will map to an element in the list, wrapping around if num clients exceeds size of list. Includes Listen Server. This is the target frame rate, e.g, &quot;20&quot; for 20fps, which will result in 1/20 second tick steps.</summary>
	public TArray<int> ClientFixedFPS;
	///<summary>Customizable settings allowing to emulate latency and packetloss for game network transmissions</summary>
	public FLevelEditorPlayNetworkEmulationSettings NetworkEmulationSettings;
	///<summary>The last known screen size for the first instance window (in pixels).</summary>
	public FIntPoint LastSize;
	///<summary>The last known screen positions of multiple instance windows (in pixels).</summary>
	public TArray<FIntPoint> MultipleInstancePositions;
	///<summary>The name of the last platform that the user ran a play session on.</summary>
	public string LastExecutedLaunchDevice;
	///<summary>The name of the last device that the user ran a play session on.</summary>
	public string LastExecutedLaunchName;
	///<summary>The last type of play-on session the user ran.</summary>
	public ELaunchModeType LastExecutedLaunchModeType;
	///<summary>The last type of play location the user ran.</summary>
	public EPlayModeLocations LastExecutedPlayModeLocation;
	///<summary>The last type of play session the user ran.</summary>
	public EPlayModeType LastExecutedPlayModeType;
	///<summary>The name of the last device that the user ran a play session on.</summary>
	public string LastExecutedPIEPreviewDevice;
	///<summary>Collection of common screen resolutions on mobile phones.</summary>
	public TArray<FPlayScreenResolution> LaptopScreenResolutions;
	///<summary>Collection of common screen resolutions on desktop monitors.</summary>
	public TArray<FPlayScreenResolution> MonitorScreenResolutions;
	///<summary>Collection of common screen resolutions on mobile phones.</summary>
	public TArray<FPlayScreenResolution> PhoneScreenResolutions;
	///<summary>Collection of common screen resolutions on tablet devices.</summary>
	public TArray<FPlayScreenResolution> TabletScreenResolutions;
	///<summary>Collection of common screen resolutions on television screens.</summary>
	public TArray<FPlayScreenResolution> TelevisionScreenResolutions;
	///<summary>DeviceToEmulate</summary>
	public string DeviceToEmulate;
	///<summary>PIESafeZoneOverride</summary>
	public FMargin PIESafeZoneOverride;
	///<summary>CustomUnsafeZoneStarts</summary>
	public TArray<FVector2D> CustomUnsafeZoneStarts;
	///<summary>CustomUnsafeZoneDimensions</summary>
	public TArray<FVector2D> CustomUnsafeZoneDimensions;
}
