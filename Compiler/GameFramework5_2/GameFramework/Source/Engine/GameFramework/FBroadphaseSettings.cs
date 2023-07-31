#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings pertaining to which PhysX broadphase to use, and settings for MBP if that is the chosen broadphase type</summary>
[CppInclude("GameFramework/WorldSettings.h")]
public partial struct FBroadphaseSettings {
	public bool bUseMBPOnClient;
	public bool bUseMBPOnServer;
	public bool bUseMBPOuterBounds;
	public FBox MBPBounds;
	public FBox MBPOuterBounds;
	public uint MBPNumSubdivs;
}
