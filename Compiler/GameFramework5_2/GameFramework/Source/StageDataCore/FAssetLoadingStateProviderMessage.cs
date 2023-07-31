#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Message sent to indicate that the node has entered or exited a loading state.</summary>
[CppInclude("StageMessages.h")]
public partial struct FAssetLoadingStateProviderMessage {
	public EStageLoadingState LoadingState;
	public string AssetName;
}
