#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/UpdateLevelVisibilityLevelInfo.h")]
///<summary>This structure is used to pass arguments to ServerUpdateLevelVisibilty() and ServerUpdateMultipleLevelsVisibility() server RPC functions</summary>
public partial struct FUpdateLevelVisibilityLevelInfo {
// UpdateLevelVisibilityLevelInfo
	public string PackageName;
	public string FileName;
	public FNetLevelVisibilityTransactionId VisibilityRequestId;
	public bool bIsVisible;
	public bool bTryMakeVisible;
	public bool bSkipCloseOnError;
}
