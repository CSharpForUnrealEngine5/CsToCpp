#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BPGraphClipboardData.h")]
///<summary>A helper struct for copying a Blueprint Function to the clipboard</summary>
public partial struct FBPGraphClipboardData {
// BPGraphClipboardData
	public string GraphName;
	public byte GraphType;
	public TWeakObjectPtr<UBlueprint> OriginalBlueprint;
	public string NodesString;
}
