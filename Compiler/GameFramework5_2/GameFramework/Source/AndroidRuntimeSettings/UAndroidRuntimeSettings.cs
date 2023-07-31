#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements the settings for the Android runtime platform.</summary>
[CppInclude("AndroidRuntimeSettings.h")]
public partial class UAndroidRuntimeSettings : UObject {
	///<summary>The official name of the product (same as the name you use on the Play Store web site). Note: Must have at least 2 sections separated by a period and be unique!</summary>
	public string PackageName;
	///<summary>The version number used to indicate newer versions in the Store</summary>
	public int StoreVersion;
	///<summary>Offset to add to store version for APKs generated for arm64</summary>
	public int StoreVersionOffsetArm64;
	///<summary>Offset to add to store version for APKs generated for x86_64</summary>
	public int StoreVersionOffsetX8664;
	///<summary>The visual application name displayed for end users</summary>
	public string ApplicationDisplayName;
	///<summary>The visual version displayed for end users</summary>
	public string VersionDisplayName;
	///<summary>What OS version the app is allowed to be installed on (do not set this lower than 26)</summary>
	public int MinSDKVersion;
	///<summary>What OS version the app is expected to run on (do not set this lower than 26)</summary>
	public int TargetSDKVersion;
	///<summary>Preferred install location for the application</summary>
	public EAndroidInstallLocation InstallLocation;
	///<summary>Enable -Xlint:unchecked and -Xlint:depreciation for Java compiling (Gradle only)</summary>
	public bool bEnableLint;
	///<summary>Should the data be placed into the .apk file instead of a separate .obb file. Amazon requires this to be enabled, but Google Play Store will not allow .apk files larger than 100MB, so only small games will work with this enabled.</summary>
	public bool bPackageDataInsideApk;
	///<summary>If checked, both batch (.bat) files and shell script (.command) files will be generated, otherwise only done for the current system (default)</summary>
	public bool bCreateAllPlatformsInstall;
	///<summary>Disable the verification of an OBB file when it is downloaded or on first start when in a distribution build.</summary>
	public bool bDisableVerifyOBBOnStartUp;
	///<summary>If checked, OBB is limited to 1 GiB.</summary>
	public bool bForceSmallOBBFiles;
	///<summary>If checked, OBB is not limited to 2 GiB allowed by Google Play Store (still limited to 4 GiB ZIP limit).</summary>
	public bool bAllowLargeOBBFiles;
	///<summary>If checked, a patch OBB is generated for files not fitting in the main OBB (requires using multiple PAK files so split up content by chunk id).</summary>
	public bool bAllowPatchOBBFile;
	///<summary>If checked, up to two additional overflow OBB files are generated for files not fitting in the patch OBB (requires using multiple PAK files so split up content by chunk id).</summary>
	public bool bAllowOverflowOBBFiles;
	///<summary>If checked, UnrealGame files will be placed in ExternalFilesDir which is removed on uninstall.</summary>
	public bool bUseExternalFilesDir;
	///<summary>If checked, log files will always be placed in a publicly available directory (either /sdcard/Android or /sdcard/UnrealGame).</summary>
	public bool bPublicLogFiles;
	///<summary>The permitted orientation of the application on the device</summary>
	public EAndroidScreenOrientation Orientation;
	///<summary>Maximum supported aspect ratio (width / height). Android will automatically letterbox application on devices with bigger aspect ratio</summary>
	public float MaxAspectRatio;
	///<summary>Enables use of the display cutout area on Android 9+</summary>
	public bool bUseDisplayCutout;
	///<summary>Should we restore scheduled local notifications on reboot? This will add a receiver for boot complete and a permission to the manifest.</summary>
	public bool bRestoreNotificationsOnReboot;
	///<summary>Should the software navigation buttons be hidden or not</summary>
	public bool bFullScreen;
	///<summary>bEnableNewKeyboard</summary>
	public bool bEnableNewKeyboard;
	///<summary>The preferred depth buffer bitcount for Android</summary>
	public EAndroidDepthBufferPreference DepthBufferPreference;
	///<summary>Verifies the device supports at least one of the cooked texture formats at runtime</summary>
	public bool bValidateTextureFormats;
	///<summary>When building for MinSDKVersion &gt;= 23 gradle will leave native libs uncompressed in the apk. This flag might be helpful for builds that are not intended to be distributed via Google Play</summary>
	public bool bForceCompressNativeLibs;
	///<summary>Generates Android binary with RELR and APS2 relocation tables when building for MinSDKVersion &gt;= 28 or just APS2 when building for MinSDKVersion &gt;= 23</summary>
	public bool bEnableAdvancedBinaryCompression;
	///<summary>Enables generating AAB bundle</summary>
	public bool bEnableBundle;
	///<summary>Enables generating universal APK from bundle</summary>
	public bool bEnableUniversalAPK;
	///<summary>Separate ABIs into their own APK in bundle</summary>
	public bool bBundleABISplit;
	///<summary>Separate resources by language into their own APK in bundle</summary>
	public bool bBundleLanguageSplit;
	///<summary>Separate resources by density into their own APK in bundle</summary>
	public bool bBundleDensitySplit;
	///<summary>Any extra tags for the &lt;manifest&gt; node</summary>
	public TArray<string> ExtraManifestNodeTags;
	///<summary>Any extra tags for the &lt;application&gt; node</summary>
	public TArray<string> ExtraApplicationNodeTags;
	///<summary>Any extra tags for the com.epicgames.unreal.GameActivity &lt;activity&gt; node</summary>
	public string ExtraApplicationSettings;
	///<summary>ExtraActivityNodeTags</summary>
	public TArray<string> ExtraActivityNodeTags;
	///<summary>Any extra settings for the main &lt;activity&gt; section (an optional file &lt;Project&gt;/Build/Android/ManifestApplicationActivtyAdditions.txt will also be included)</summary>
	public string ExtraActivitySettings;
	///<summary>Any extra permissions your app needs (an optional file &lt;Project&gt;/Build/Android/ManifestRequirementsAdditions.txt will also be included,</summary>
	public TArray<string> ExtraPermissions;
	///<summary>Add required permission to support Voice chat</summary>
	public bool bAndroidVoiceEnabled;
	///<summary>Add required permission and support to allow multicast/broadcast Wi-Fi traffic through network interface</summary>
	public bool bEnableMulticastSupport;
	///<summary>Package for an Oculus Mobile device</summary>
	public TArray<EOculusMobileDevice> PackageForOculusMobile;
	///<summary>Removes Oculus Signature Files (osig) from APK if Quest/Go APK signed for distribution and enables entitlement checker</summary>
	public bool bRemoveOSIG;
	///<summary>This is the file that keytool outputs, specified with the -keystore parameter (file should be in &lt;Project&gt;/Build/Android)</summary>
	public string KeyStore;
	///<summary>This is the name of the key that you specified with the -alias parameter to keytool</summary>
	public string KeyAlias;
	///<summary>This is the password that you specified FOR THE KEYSTORE NOT THE KEY, when running keytool (either with -storepass or by typing it in).</summary>
	public string KeyStorePassword;
	///<summary>This is the password for the key that you may have specified with keytool, if it&#39;s different from the keystore password. Leave blank to use same as Keystore</summary>
	public string KeyPassword;
	///<summary>Enable Arm64 support?</summary>
	public bool bBuildForArm64;
	///<summary>Enable x86-64 support? [CURRENTLY FOR FULL SOURCE GAMES ONLY]</summary>
	public bool bBuildForX8664;
	///<summary>Include shaders for devices supporting OpenGL ES 3.2 and above (default)</summary>
	public bool bBuildForES31;
	///<summary>Support the Vulkan RHI and include Vulkan shaders</summary>
	public bool bSupportsVulkan;
	///<summary>Enable Vulkan SM5 rendering support</summary>
	public bool bSupportsVulkanSM5;
	///<summary>Directory for Debug Vulkan Layers to package</summary>
	public FDirectoryPath DebugVulkanLayerDirectory;
	///<summary>Debug Vulkan Device Layers to enable</summary>
	public TArray<string> DebugVulkanDeviceLayers;
	///<summary>Debug Vulkan Instance Layers to enable</summary>
	public TArray<string> DebugVulkanInstanceLayers;
	///<summary>Whether to render to an offscreen surface instead of render to backbuffer directly on android opengl platform. Enable it if you&#39;d like to support UMG background blur on android opengl.</summary>
	public bool bAndroidOpenGLSupportsBackbufferSampling;
	///<summary>Whether to detect Vulkan device support by default, if the project is packaged with Vulkan support. If unchecked, the -detectvulkan commandline will enable Vulkan detection.</summary>
	public bool bDetectVulkanByDefault;
	///<summary>Build the shipping config with hidden visibility by default. Results in smaller .so file but will also removes symbols used to display callstack dumps.</summary>
	public bool bBuildWithHiddenSymbolVisibility;
	///<summary>Disables extra checks for buffer overflows, comes with perf improvement, but might make tracing stack corruptions in production harder. Note that _FORTIFY_SOURCE=2 is still enabled by the toolchain providing lightweight stack checks</summary>
	public bool bDisableStackProtector;
	///<summary>Disable libc++_shared dependency validation in all .so files linked with libUnreal.so</summary>
	public bool bDisableLibCppSharedDependencyValidation;
	///<summary>Always save .so file with symbols allowing use of addr2line on raw callstack addresses.</summary>
	public bool bSaveSymbols;
	///<summary>If true, strip shader reflection information under Android</summary>
	public bool bStripShaderReflection;
	///<summary>Should Google Play support be enabled?</summary>
	public bool bEnableGooglePlaySupport;
	///<summary>Enabling this adds GET_ACCOUNTS to manifest and user must give permission.  Required for reset achievements.</summary>
	public bool bUseGetAccounts;
	///<summary>The app id obtained from the Google Play Developer Console</summary>
	public string GamesAppID;
	///<summary>Mapping of game achievement names to IDs generated by Google Play.</summary>
	public TArray<FGooglePlayAchievementMapping> AchievementMap;
	///<summary>Mapping of game leaderboard names to IDs generated by Google Play.</summary>
	public TArray<FGooglePlayLeaderboardMapping> LeaderboardMap;
	///<summary>Enabling this requests snapshots support for saved games during Google Play login.</summary>
	public bool bEnableSnapshots;
	///<summary>Enabling this includes the AdMob SDK and will be detected by Google Play Console on upload of APK.  Disable if you do not need ads to remove this warning.</summary>
	public bool bSupportAdMob;
	///<summary>AdMob Application ID (see https://support.google.com/admob/answer/7356431)</summary>
	public string AdMobAppID;
	///<summary>Admob TagForChildDirectedTreatment (see https://developers.google.com/admob/android/targeting)</summary>
	public ETagForChildDirectedTreatment TagForChildDirectedTreatment;
	///<summary>Admob TagForUnderAgeOfConsent (see https://developers.google.com/admob/android/targeting)</summary>
	public ETagForUnderAgeOfConsent TagForUnderAgeOfConsent;
	///<summary>Admob MaxAdContentRating (see https://developers.google.com/admob/android/targeting)</summary>
	public EMaxAdContentRating MaxAdContentRating;
	///<summary>The unique identifier for the ad obtained from AdMob.</summary>
	public string AdMobAdUnitID;
	///<summary>Identifiers for ads obtained from AdMob</summary>
	public TArray<string> AdMobAdUnitIDs;
	///<summary>The unique identifier for this application (needed for IAP)</summary>
	public string GooglePlayLicenseKey;
	///<summary>The sender id obtained from Firebase Console, leave blank to disable (associate this with your app in Google Player Developer Console).</summary>
	public string GCMClientSenderID;
	///<summary>Show the launch image as a startup slash screen</summary>
	public bool bShowLaunchImage;
	///<summary>Allows accelerometer, magnetometer, and gyroscope event handling, disabling may improve performance.</summary>
	public bool bAllowIMU;
	///<summary>If checked, Bluetooth connected controllers will send input</summary>
	public bool bAllowControllers;
	///<summary>If checked, controllers will not send Android_Back and Android_Menu events that might cause unnecce</summary>
	public bool bBlockAndroidKeysOnControllers;
	///<summary>Block force feedback on the device when controllers are attached.</summary>
	public bool bControllersBlockDeviceFeedback;
	///<summary>Android encoding options.</summary>
	public EAndroidAudio AndroidAudio;
	///<summary>Sample rate to run the audio mixer with.</summary>
	public int AudioSampleRate;
	///<summary>The amount of audio to compute each callback block. Lower values decrease latency but may increase CPU cost.</summary>
	public int AudioCallbackBufferFrameSize;
	///<summary>The number of buffers to keep enqueued. More buffers increases latency, but can compensate for variable compute availability in audio callbacks on some platforms.</summary>
	public int AudioNumBuffersToEnqueue;
	///<summary>The max number of channels (voices) to limit for this platform. The max channels used will be the minimum of this value and the global audio quality settings. A value of 0 will not apply a platform channel count max.</summary>
	public int AudioMaxChannels;
	///<summary>The number of workers to use to compute source audio. Will only use up to the max number of sources. Will evenly divide sources to each source worker.</summary>
	public int AudioNumSourceWorkers;
	///<summary>Which of the currently enabled spatialization plugins to use.</summary>
	public string SpatializationPlugin;
	///<summary>Which of the currently enabled source data override plugins to use.</summary>
	public string SourceDataOverridePlugin;
	///<summary>Which of the currently enabled reverb plugins to use.</summary>
	public string ReverbPlugin;
	///<summary>Which of the currently enabled occlusion plugins to use.</summary>
	public string OcclusionPlugin;
	///<summary>Various overrides for how this platform should handle compression and decompression</summary>
	public FPlatformRuntimeAudioCompressionOverrides CompressionOverrides;
	///<summary>This determines the max amount of memory that should be used for the cache at any given time. If set low (&lt;= 8 MB), it lowers the size of individual chunks of audio during cook.</summary>
	public int CacheSizeKB;
	///<summary>This overrides the default max chunk size used when chunking audio for stream caching (ignored if &lt; 0)</summary>
	public int MaxChunkSizeOverrideKB;
	///<summary>bResampleForDevice</summary>
	public bool bResampleForDevice;
	///<summary>Quality Level to COOK SoundCues at (if set, all other levels will be stripped by the cooker).</summary>
	public int SoundCueCookQualityIndex;
	///<summary>Mapping of which sample rates are used for each sample rate quality for a specific platform.</summary>
	public float MaxSampleRate;
	///<summary>HighSampleRate</summary>
	public float HighSampleRate;
	///<summary>MedSampleRate</summary>
	public float MedSampleRate;
	///<summary>LowSampleRate</summary>
	public float LowSampleRate;
	///<summary>MinSampleRate</summary>
	public float MinSampleRate;
	///<summary>Scales all compression qualities when cooking to this platform. For example, 0.5 will halve all compression qualities, and 1.0 will leave them unchanged.</summary>
	public float CompressionQualityModifier;
	///<summary>When set to anything beyond 0, this will ensure any SoundWaves longer than this value, in seconds, to stream directly off of the disk.</summary>
	public float AutoStreamingThreshold;
	///<summary>Several Android graphics debuggers require configuration changes to be made to your application in order to operate. Choosing an option from this menu will configure your project to work with that graphics debugger.</summary>
	public EAndroidGraphicsDebugger AndroidGraphicsDebugger;
	///<summary>The path to your Mali Graphics Debugger installation (eg C:/Program Files/ARM/Mali Developer Tools/Mali Graphics Debugger v4.2.0)</summary>
	public FDirectoryPath MaliGraphicsDebuggerPath;
	///<summary>If checked, this will disable the security.perf_harden flag on the Android device when launching or installing your app via the generated batch file.</summary>
	public bool bEnableMaliPerfCounters;
	///<summary>Include ETC2 textures when packaging with the Android (Multi) variant.</summary>
	public bool bMultiTargetFormat_ETC2;
	///<summary>Include DXT textures when packaging with the Android (Multi) variant.</summary>
	public bool bMultiTargetFormat_DXT;
	///<summary>Include ASTC textures when packaging with the Android (Multi) variant.</summary>
	public bool bMultiTargetFormat_ASTC;
	///<summary>Priority for the ETC2 texture format when launching on device or packaging using Android_Multi. The highest priority format supported by the device will be used. Default value is 0.2.</summary>
	public float TextureFormatPriority_ETC2;
	///<summary>Priority for the DXT texture format when launching on device or packaging using Android_Multi. The highest priority format supported by the device will be used. Default value is 0.6.</summary>
	public float TextureFormatPriority_DXT;
	///<summary>Priority for the ASTC texture format when launching on device or packaging using Android_Multi. The highest priority format supported by the device will be used. Default value is 0.9.</summary>
	public float TextureFormatPriority_ASTC;
	///<summary>Which SDK to package and compile Java with (a specific version or (without quotes) &#39;latest&#39; for latest version on disk, or &#39;matchndk&#39; to match the NDK API Level)</summary>
	public string SDKAPILevelOverride;
	///<summary>Which NDK to compile with (a specific version or (without quotes) &#39;latest&#39; for latest version on disk). Note that choosing android-21 or later won&#39;t run on pre-5.0 devices.</summary>
	public string NDKAPILevelOverride;
	///<summary>Which build-tools to package with (a specific version or (without quotes) &#39;latest&#39; for latest version on disk).</summary>
	public string BuildToolsOverride;
	///<summary>Whether to enable LOD streaming for landscape visual meshes. Only supported on feature level ES3.1 or above.</summary>
	public bool bStreamLandscapeMeshLODs;
	///<summary>Enables WebViews to use DOM storage API</summary>
	public bool bEnableDomStorage;
}
