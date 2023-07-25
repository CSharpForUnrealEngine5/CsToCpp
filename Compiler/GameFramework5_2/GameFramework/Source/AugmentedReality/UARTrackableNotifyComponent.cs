#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARTrackableNotifyComponent.h")]
///<summary>Component used to listen to ar trackable object changes</summary>
public partial class UARTrackableNotifyComponent : UActorComponent {
// ARTrackableNotifyComponent
	public FTrackableDelegate OnAddTrackedGeometry;
	public FTrackableDelegate OnUpdateTrackedGeometry;
	public FTrackableDelegate OnRemoveTrackedGeometry;
	public FTrackablePlaneDelegate OnAddTrackedPlane;
	public FTrackablePlaneDelegate OnUpdateTrackedPlane;
	public FTrackablePlaneDelegate OnRemoveTrackedPlane;
	public FTrackablePointDelegate OnAddTrackedPoint;
	public FTrackablePointDelegate OnUpdateTrackedPoint;
	public FTrackablePointDelegate OnRemoveTrackedPoint;
	public FTrackableImageDelegate OnAddTrackedImage;
	public FTrackableImageDelegate OnUpdateTrackedImage;
	public FTrackableImageDelegate OnRemoveTrackedImage;
	public FTrackableFaceDelegate OnAddTrackedFace;
	public FTrackableFaceDelegate OnUpdateTrackedFace;
	public FTrackableFaceDelegate OnRemoveTrackedFace;
	public FTrackableEnvProbeDelegate OnAddTrackedEnvProbe;
	public FTrackableEnvProbeDelegate OnUpdateTrackedEnvProbe;
	public FTrackableEnvProbeDelegate OnRemoveTrackedEnvProbe;
	public FTrackableObjectDelegate OnAddTrackedObject;
	public FTrackableObjectDelegate OnUpdateTrackedObject;
	public FTrackableObjectDelegate OnRemoveTrackedObject;
}
