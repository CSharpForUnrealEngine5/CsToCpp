#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/WorldSettings.h")]
///<summary>Settings pertaining to which PhysX broadphase to use, and settings for MBP if that is the chosen broadphase type</summary>
public partial struct FBroadphaseSettings {
// BroadphaseSettings
	public bool bUseMBPOnClient;
	public bool bUseMBPOnServer;
	public bool bUseMBPOuterBounds;
	public FBox MBPBounds;
	public FBox MBPOuterBounds;
	public uint MBPNumSubdivs;
}
