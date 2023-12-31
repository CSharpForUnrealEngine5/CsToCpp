namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/LevelStreamingVolume.h")]
public partial class ALevelStreamingVolume : AVolume {
	public static UClass StaticClass() {return default;}
	///<summary>Levels names affected by this level streaming volume.</summary>
	public TArray<FName> StreamingLevelNames;
	///<summary>If true, this streaming volume should only be used for editor streaming level previs.</summary>
	public bool bEditorPreVisOnly;
	///<summary>If true, this streaming volume is ignored by the streaming volume code.  Used to either</summary>
	public bool bDisabled;
	///<summary>Determines what this volume is used for, e.g. whether to control loading, loading and visibility or just visibilty (blocking on load)</summary>
	public EStreamingVolumeUsage StreamingUsage;
}
