#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/PlayerController.h")]
///<summary>This structure is used to pass arguments to ClientUpdateMultipleLevelsStreamingStatus() client RPC function</summary>
public partial struct FUpdateLevelStreamingLevelStatus {
// UpdateLevelStreamingLevelStatus
	public string PackageName;
	public int LODIndex;
	public bool bNewShouldBeLoaded;
	public bool bNewShouldBeVisible;
	public bool bNewShouldBlockOnLoad;
	public bool bNewShouldBlockOnUnload;
}
