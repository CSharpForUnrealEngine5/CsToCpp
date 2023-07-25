#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GroomCacheImportOptions.h")]
public partial struct FGroomCacheImportSettings {
// GroomCacheImportSettings
	public bool bImportGroomCache;
	public EGroomCacheImportType ImportType;
	public int FrameStart;
	public int FrameEnd;
	public bool bSkipEmptyFrames;
	public bool bImportGroomAsset;
	public FSoftObjectPath GroomAsset;
	public bool bOverrideConversionSettings;
	public FGroomConversionSettings ConversionSettings;
}
