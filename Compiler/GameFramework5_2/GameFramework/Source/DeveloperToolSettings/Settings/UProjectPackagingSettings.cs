#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements the Editor&#39;s user settings.</summary>
[CppInclude("Settings/ProjectPackagingSettings.h")]
public partial class UProjectPackagingSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Specifies whether to build the game executable during packaging.</summary>
	public EProjectPackagingBuild Build;
	///<summary>The build configuration for which the project is packaged.</summary>
	public EProjectPackagingBuildConfigurations BuildConfiguration;
	///<summary>Name of the target to build</summary>
	public string BuildTarget;
	///<summary>If enabled, a full rebuild will be enforced each time the project is being packaged.</summary>
	public bool FullRebuild;
	///<summary>If enabled, a distribution build will be created and the shipping configuration will be used</summary>
	public bool ForDistribution;
	///<summary>If enabled, debug files will be included in staged shipping builds.</summary>
	public bool IncludeDebugFiles;
	///<summary>BlueprintNativizationMethod</summary>
	public EProjectPackagingBlueprintNativizationMethod BlueprintNativizationMethod;
	///<summary>NativizeBlueprintAssets</summary>
	public TArray<FFilePath> NativizeBlueprintAssets;
	///<summary>bIncludeNativizedAssetsInProjectGeneration</summary>
	public bool bIncludeNativizedAssetsInProjectGeneration;
	///<summary>bExcludeMonolithicEngineHeadersInNativizedCode</summary>
	public bool bExcludeMonolithicEngineHeadersInNativizedCode;
	///<summary>If enabled, all content will be put into a one or more .pak files instead of many individual files (default = enabled).</summary>
	public bool UsePakFile;
	///<summary>If enabled, use .utoc/.ucas container files for staged/packaged package data instead of pak.</summary>
	public bool bUseIoStore;
	///<summary>If enabled, use Zen storage server for storing and fetching cooked data instead of using the local file system.</summary>
	public bool bUseZenStore;
	///<summary>If enabled, staging will make a binary config file for faster loading.</summary>
	public bool bMakeBinaryConfig;
	///<summary>If enabled, will generate pak file chunks.  Assets can be assigned to chunks in the editor or via a delegate (See ShooterGameDelegates.cpp).</summary>
	public bool bGenerateChunks;
	///<summary>If enabled, no platform will generate chunks, regardless of settings in platform-specific ini files.</summary>
	public bool bGenerateNoChunks;
	///<summary>Normally during chunk generation all dependencies of a package in a chunk will be pulled into that package&#39;s chunk.</summary>
	public bool bChunkHardReferencesOnly;
	///<summary>If true, individual files are only allowed to be in a single chunk and it will assign it to the lowest number requested</summary>
	public bool bForceOneChunkPerFile;
	///<summary>If &gt; 0 this sets a maximum size per chunk. Chunks larger than this size will be split into multiple pak files such as pakchunk0_s1</summary>
	public long MaxChunkSize;
	///<summary>If enabled, will generate data for HTTP Chunk Installer. This data can be hosted on webserver to be installed at runtime. Requires &quot;Generate Chunks&quot; enabled.</summary>
	public bool bBuildHttpChunkInstallData;
	///<summary>When &quot;Build HTTP Chunk Install Data&quot; is enabled this is the directory where the data will be build to.</summary>
	public FDirectoryPath HttpChunkInstallDataDirectory;
	///<summary>Whether to write staging metadata back to the asset registry. This metadata contains information such as</summary>
	public EAssetRegistryWritebackMethod WriteBackMetadataToAssetRegistry;
	///<summary>Create compressed cooked packages (decreased deployment size)</summary>
	public bool bCompressed;
	///<summary>A comma separated list of formats to use for .pak file and IoStore compression. If more than one is specified, the list is in order of priority, with fallbacks to other formats</summary>
	public string PackageCompressionFormat;
	///<summary>Force use of PackageCompressionFormat (do not use override HardwareCompressionFormat from DDPI)</summary>
	public bool bForceUseProjectCompressionFormatIgnoreHardwareOverride;
	///<summary>A generic setting for allowing a project to control compression settings during .pak file and iostore compression.</summary>
	public string PackageAdditionalCompressionOptions;
	///<summary>For compressors with multiple methods, select one.  eg. for Oodle you may use one of {Kraken,Mermaid,Selkie,Leviathan}</summary>
	public string PackageCompressionMethod;
	///<summary>* For compressors with variable levels, select the compressor effort level, which makes packages smaller but takes more time to encode.</summary>
	public int PackageCompressionLevel_DebugDevelopment;
	///<summary>PackageCompressionLevel_TestShipping</summary>
	public int PackageCompressionLevel_TestShipping;
	///<summary>PackageCompressionLevel_Distribution</summary>
	public int PackageCompressionLevel_Distribution;
	///<summary>A generic setting which is used to determine whether it is worth using compression for a block of data when creating IoStore or .pak files.</summary>
	public int PackageCompressionMinBytesSaved;
	///<summary>A generic setting which is used to determine whether it is worth using compression for a block of data when creating IoStore or .pak files.</summary>
	public int PackageCompressionMinPercentSaved;
	///<summary>Specifies if DDC should be used to store and retrieve compressed data when creating IoStore containers.</summary>
	public bool bPackageCompressionEnableDDC;
	///<summary>Specifies the minimum (uncompressed) size for storing a compressed IoStore chunk in DDC.</summary>
	public int PackageCompressionMinSizeToConsiderDDC;
	///<summary>Version name for HTTP Chunk Install Data.</summary>
	public string HttpChunkInstallDataVersion;
	///<summary>Specifies whether to include an installer for prerequisites of packaged games, such as redistributable operating system components, on platforms that support it.</summary>
	public bool IncludePrerequisites;
	///<summary>Specifies whether to include prerequisites alongside the game executable.</summary>
	public bool IncludeAppLocalPrerequisites;
	///<summary>By default shader code gets saved inline inside material assets,</summary>
	public bool bShareMaterialShaderCode;
	///<summary>With this option off, the shader code will be stored in the library essentially in a random order,</summary>
	public bool bDeterministicShaderCodeOrder;
	///<summary>By default shader shader code gets saved into individual platform agnostic files,</summary>
	public bool bSharedMaterialNativeLibraries;
	///<summary>A directory containing additional prerequisite packages that should be staged in the executable directory. Can be relative to $(EngineDir) or $(ProjectDir)</summary>
	public FDirectoryPath ApplocalPrerequisitesDirectory;
	///<summary>Specifies whether to include the crash reporter in the packaged project.</summary>
	public bool IncludeCrashReporter;
	///<summary>Predefined sets of culture whose internationalization data should be packaged.</summary>
	public EProjectPackagingInternationalizationPresets InternationalizationPreset;
	///<summary>Cultures whose data should be cooked, staged, and packaged.</summary>
	public TArray<string> CulturesToStage;
	///<summary>List of localization targets that should be chunked during cooking (if using chunks)</summary>
	public TArray<string> LocalizationTargetsToChunk;
	///<summary>The chunk ID that should be used as the catch-all chunk for any non-asset localized strings</summary>
	public int LocalizationTargetCatchAllChunkId;
	///<summary>Cook all things in the project content directory</summary>
	public bool bCookAll;
	///<summary>Cook only maps (this only affects the cookall flag)</summary>
	public bool bCookMapsOnly;
	///<summary>Encrypt ini files inside of the pak file</summary>
	public bool bEncryptIniFiles_DEPRECATED;
	///<summary>Encrypt the pak index</summary>
	public bool bEncryptPakIndex_DEPRECATED;
	///<summary>Enable the early downloader pak file pakearly.txt</summary>
	public bool GenerateEarlyDownloaderPakFile_DEPRECATED;
	///<summary>Don&#39;t include content in any editor folders when cooking.  This can cause issues with missing content in cooked games if the content is being used.</summary>
	public bool bSkipEditorContent;
	///<summary>Don&#39;t include movies by default when staging/packaging</summary>
	public bool bSkipMovies;
	///<summary>If SkipMovies is true, these specific movies will still be added to the .pak file (if using a .pak file; otherwise they&#39;re copied as individual files)</summary>
	public TArray<string> UFSMovies;
	///<summary>If SkipMovies is true, these specific movies will be copied when packaging your project, but are not supposed to be part of the .pak file</summary>
	public TArray<string> NonUFSMovies;
	///<summary>If set, only these specific pak files will be compressed. This should take the form of &quot;*pakchunk0*&quot;</summary>
	public TArray<string> CompressedChunkWildcard;
	///<summary>, EditAnywhere, Category = Packaging</summary>
	public TArray<string> IniKeyBlacklist;
	///<summary>List of ini file keys to strip when packaging</summary>
	public TArray<string> IniKeyDenylist;
	///<summary>, EditAnywhere, Category = Packaging</summary>
	public TArray<string> IniSectionBlacklist;
	///<summary>List of ini file sections to strip when packaging</summary>
	public TArray<string> IniSectionDenylist;
	///<summary>List of specific files to include with GenerateEarlyDownloaderPakFile</summary>
	public TArray<string> EarlyDownloaderPakFileFiles_DEPRECATED;
	///<summary>List of maps to include when no other map list is specified on commandline</summary>
	public TArray<FFilePath> MapsToCook;
	///<summary>Directories containing .uasset files that should always be cooked regardless of whether they&#39;re referenced by anything in your project</summary>
	public TArray<FDirectoryPath> DirectoriesToAlwaysCook;
	///<summary>Directories containing .uasset files that should never be cooked even if they are referenced by your project</summary>
	public TArray<FDirectoryPath> DirectoriesToNeverCook;
	///<summary>Directories containing .uasset files that are for editor testing purposes and should not be included in</summary>
	public TArray<FDirectoryPath> TestDirectoriesToNotSearch;
	///<summary>Directories containing files that should always be added to the .pak file (if using a .pak file; otherwise they&#39;re copied as individual files)</summary>
	public TArray<FDirectoryPath> DirectoriesToAlwaysStageAsUFS;
	///<summary>Directories containing files that should always be copied when packaging your project, but are not supposed to be part of the .pak file</summary>
	public TArray<FDirectoryPath> DirectoriesToAlwaysStageAsNonUFS;
	///<summary>Directories containing files that should always be added to the .pak file for a dedicated server (if using a .pak file; otherwise they&#39;re copied as individual files)</summary>
	public TArray<FDirectoryPath> DirectoriesToAlwaysStageAsUFSServer;
	///<summary>Directories containing files that should always be copied when packaging your project for a dedicated server, but are not supposed to be part of the .pak file</summary>
	public TArray<FDirectoryPath> DirectoriesToAlwaysStageAsNonUFSServer;
	///<summary>A list of custom builds that will show up in the Platforms menu to allow customized builds that make sense for your project. Will show up near Package Project in the Platforms menu.</summary>
	public TArray<FProjectBuildSettings> ProjectCustomBuilds;
	///<summary>A list of custom builds, specified in engine ini files, and not editable in editor, that will show up in the Platforms menu to allow customized builds for all projects</summary>
	public TArray<FProjectBuildSettings> EngineCustomBuilds;
}
