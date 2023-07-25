#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AzureSpatialAnchorsEventComponent.h")]
public partial class UAzureSpatialAnchorsEventComponent : UActorComponent {
// AzureSpatialAnchorsEventComponent
	public void FASAAnchorLocatedDelegate(int WatcherIdentifier,EAzureSpatialAnchorsLocateAnchorStatus Status,UObject CloudSpatialAnchor) {}
	public FASAAnchorLocatedDelegate ASAAnchorLocatedDelegate;
	public void FASALocateAnchorsCompletedDelegate(int WatcherIdentifier,bool WasCanceled) {}
	public FASALocateAnchorsCompletedDelegate ASALocateAnchorsCompleteDelegate;
	public void FASASessionUpdatedDelegate(float ReadyForCreateProgress,float RecommendedForCreateProgress,int SessionCreateHash,int SessionLocateHash,EAzureSpatialAnchorsSessionUserFeedback Feedback) {}
	public FASASessionUpdatedDelegate ASASessionUpdatedDelegate;
}
