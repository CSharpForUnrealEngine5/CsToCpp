namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Per-chunk authoring data.</summary>
[CppInclude("DestructibleFractureSettings.h")]
public partial struct FDestructibleChunkParameters {
	public bool bIsSupportChunk;
	public bool bDoNotFracture;
	public bool bDoNotDamage;
	public bool bDoNotCrumble;
}
