#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCO/CustomizableObject.h")]
public partial struct FMutableLODSettings {
// MutableLODSettings
	public FPerPlatformInt MinLOD;
	public FPerQualityLevelInt MinQualityLevelLOD;
	public bool bOverrideLODStreamingSettings;
	public FPerPlatformBool bEnableLODStreaming;
	public FPerPlatformInt NumMaxStreamedLODs;
	public int NumLODsInRoot;
	public int FirstLODAvailable;
	public bool bLODStreamingEnabled;
	public uint NumLODsToStream;
}
