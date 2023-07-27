#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/LevelStreamingVolume.h")]
public partial class ALevelStreamingVolume : AVolume {
// LevelStreamingVolume
	public TArray<string> StreamingLevelNames;
	public bool bEditorPreVisOnly;
	public bool bDisabled;
	public EStreamingVolumeUsage StreamingUsage;
}
