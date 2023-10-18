namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Various cooker settings.</summary>
[CppInclude("CookerSettings.h")]
public partial class UCookerSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>bEnableCookOnTheSide</summary>
	public bool bEnableCookOnTheSide;
	///<summary>bEnableBuildDDCInBackground</summary>
	public bool bEnableBuildDDCInBackground;
	///<summary>Enable -iterate for launch on</summary>
	public bool bIterativeCookingForLaunchOn;
	///<summary>Enable -iterate when triggering from File dropdown menu</summary>
	public bool bIterativeCookingForFileCookContent;
	///<summary>Enable -cookonthefly for launch on</summary>
	public bool bCookOnTheFlyForLaunchOn;
	///<summary>Controls log output of the cooker</summary>
	public ECookProgressDisplayMode CookProgressDisplayMode;
	///<summary>Ignore ini changes when doing iterative cooking, either in editor or out of editor</summary>
	public bool bIgnoreIniSettingsOutOfDateForIteration;
	///<summary>Ignore native header file changes when doing iterative cooking, either in editor or out of editor</summary>
	public bool bIgnoreScriptPackagesOutOfDateForIteration;
	///<summary>Whether or not to compile Blueprints in development mode when cooking.</summary>
	public bool bCompileBlueprintsInDevelopmentMode;
	///<summary>Generate optimized component data to speed up Blueprint construction at runtime. This option can increase the overall Blueprint memory usage in a cooked build. Requires Event-Driven Loading (EDL), which is enabled by default.</summary>
	public EBlueprintComponentDataCookingMethod BlueprintComponentDataCookingMethod;
	///<summary>Should we include the property GUIDs for a Blueprint class in a cooked build, so that SaveGame archives can redirect property names via the GUIDs?</summary>
	public EBlueprintPropertyGuidsCookingMethod BlueprintPropertyGuidsCookingMethod;
	///<summary>List of class names to exclude when cooking for dedicated server</summary>
	public TArray<string> ClassesExcludedOnDedicatedServer;
	///<summary>List of module names to exclude when cooking for dedicated server</summary>
	public TArray<string> ModulesExcludedOnDedicatedServer;
	///<summary>List of class names to exclude when cooking for dedicated client</summary>
	public TArray<string> ClassesExcludedOnDedicatedClient;
	///<summary>List of module names to exclude when cooking for dedicated client</summary>
	public TArray<string> ModulesExcludedOnDedicatedClient;
	///<summary>List of r values that need to be versioned</summary>
	public TArray<string> VersionedIntRValues;
	///<summary>Quality of 0 means fastest, 3 means best quality</summary>
	public int DefaultASTCQualityBySpeed;
	///<summary>Quality of 0 means smallest (12x12 block size), 4 means best (4x4 block size)</summary>
	public int DefaultASTCQualityBySize;
	///<summary>which compressor to use for ASTC textures</summary>
	public ETextureFormatASTCCompressor DefaultASTCCompressor;
	///<summary>whether to allow ASTC HDR profile using Arm encoder, the hdr format is only supported on some devices, e.g. Apple A13, Mali-G72, Adreno (TM) 660</summary>
	public bool bAllowASTCHDRProfile;
	///<summary>If true, the editor will be able to open cooked assets (limited to a subset of supported asset types).</summary>
	public bool bAllowCookedDataInEditorBuilds;
	///<summary>Deprecated. Use BlueprintComponentDataCookingMethod instead.</summary>
	public bool bCookBlueprintComponentTemplateData;
}
