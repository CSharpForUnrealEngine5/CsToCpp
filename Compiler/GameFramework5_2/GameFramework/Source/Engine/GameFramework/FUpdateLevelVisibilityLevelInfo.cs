namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This structure is used to pass arguments to ServerUpdateLevelVisibilty() and ServerUpdateMultipleLevelsVisibility() server RPC functions</summary>
[CppInclude("GameFramework/UpdateLevelVisibilityLevelInfo.h")]
public partial struct FUpdateLevelVisibilityLevelInfo {
	public string PackageName;
	public string FileName;
	public FNetLevelVisibilityTransactionId VisibilityRequestId;
	public bool bIsVisible;
	public bool bTryMakeVisible;
	public bool bSkipCloseOnError;
}
