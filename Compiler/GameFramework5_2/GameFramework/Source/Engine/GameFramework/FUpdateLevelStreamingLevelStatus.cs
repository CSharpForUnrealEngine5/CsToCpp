namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This structure is used to pass arguments to ClientUpdateMultipleLevelsStreamingStatus() client RPC function</summary>
[CppInclude("GameFramework/PlayerController.h")]
public partial struct FUpdateLevelStreamingLevelStatus {
	public string PackageName;
	public int LODIndex;
	public bool bNewShouldBeLoaded;
	public bool bNewShouldBeVisible;
	public bool bNewShouldBlockOnLoad;
	public bool bNewShouldBlockOnUnload;
}
