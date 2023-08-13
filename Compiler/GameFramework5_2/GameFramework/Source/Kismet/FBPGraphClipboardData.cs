namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A helper struct for copying a Blueprint Function to the clipboard</summary>
[CppInclude("BPGraphClipboardData.h")]
public partial struct FBPGraphClipboardData {
	public string GraphName;
	public EGraphType GraphType;
	public TWeakObjectPtr<UBlueprint> OriginalBlueprint;
	public string NodesString;
}
