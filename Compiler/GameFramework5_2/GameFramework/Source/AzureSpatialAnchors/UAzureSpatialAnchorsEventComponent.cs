namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AzureSpatialAnchorsEventComponent.h")]
public partial class UAzureSpatialAnchorsEventComponent : UActorComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Delegates that will be cast by the ASA platform implementations.</summary>
	public void FASAAnchorLocatedDelegate(int WatcherIdentifier,EAzureSpatialAnchorsLocateAnchorStatus Status,UAzureCloudSpatialAnchor CloudSpatialAnchor) {}
	///<summary>ASAAnchorLocatedDelegate</summary>
	public FASAAnchorLocatedDelegate ASAAnchorLocatedDelegate;
	///<summary>FASALocateAnchorsCompletedDelegate</summary>
	public void FASALocateAnchorsCompletedDelegate(int WatcherIdentifier,bool WasCanceled) {}
	///<summary>ASALocateAnchorsCompleteDelegate</summary>
	public FASALocateAnchorsCompletedDelegate ASALocateAnchorsCompleteDelegate;
	///<summary>FASASessionUpdatedDelegate</summary>
	public void FASASessionUpdatedDelegate(float ReadyForCreateProgress,float RecommendedForCreateProgress,int SessionCreateHash,int SessionLocateHash,EAzureSpatialAnchorsSessionUserFeedback Feedback) {}
	///<summary>ASASessionUpdatedDelegate</summary>
	public FASASessionUpdatedDelegate ASASessionUpdatedDelegate;
}
