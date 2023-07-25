#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("StageMessages.h")]
///<summary>Message sent to indicate that the node has entered or exited a loading state.</summary>
public partial struct FAssetLoadingStateProviderMessage {
// AssetLoadingStateProviderMessage
	public EStageLoadingState LoadingState;
	public string AssetName;
}
