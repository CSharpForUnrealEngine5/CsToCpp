#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Component used to listen to ar trackable object changes</summary>
[CppInclude("ARTrackableNotifyComponent.h")]
public partial class UARTrackableNotifyComponent : UActorComponent {
	///<summary>Event that happens when any new trackable ar item is added</summary>
	public FTrackableDelegate OnAddTrackedGeometry;
	///<summary>Event that happens when any trackable ar item is updated</summary>
	public FTrackableDelegate OnUpdateTrackedGeometry;
	///<summary>Event that happens when any trackable ar item is removed from the scene</summary>
	public FTrackableDelegate OnRemoveTrackedGeometry;
	///<summary>Event that happens when any new ar plane item is added</summary>
	public FTrackablePlaneDelegate OnAddTrackedPlane;
	///<summary>Event that happens when any ar plane item is updated</summary>
	public FTrackablePlaneDelegate OnUpdateTrackedPlane;
	///<summary>Event that happens when any ar plane item is removed from the scene</summary>
	public FTrackablePlaneDelegate OnRemoveTrackedPlane;
	///<summary>Event that happens when any new ar Point item is added</summary>
	public FTrackablePointDelegate OnAddTrackedPoint;
	///<summary>Event that happens when any ar Point item is updated</summary>
	public FTrackablePointDelegate OnUpdateTrackedPoint;
	///<summary>Event that happens when any ar Point item is removed from the scene</summary>
	public FTrackablePointDelegate OnRemoveTrackedPoint;
	///<summary>Event that happens when any new ar Image item is added</summary>
	public FTrackableImageDelegate OnAddTrackedImage;
	///<summary>Event that happens when any ar Image item is updated</summary>
	public FTrackableImageDelegate OnUpdateTrackedImage;
	///<summary>Event that happens when any ar Image item is removed from the scene</summary>
	public FTrackableImageDelegate OnRemoveTrackedImage;
	///<summary>Event that happens when any new ar Face item is added</summary>
	public FTrackableFaceDelegate OnAddTrackedFace;
	///<summary>Event that happens when any ar Face item is updated</summary>
	public FTrackableFaceDelegate OnUpdateTrackedFace;
	///<summary>Event that happens when any ar Face item is removed from the scene</summary>
	public FTrackableFaceDelegate OnRemoveTrackedFace;
	///<summary>Event that happens when any new ar environment capture probe item is added</summary>
	public FTrackableEnvProbeDelegate OnAddTrackedEnvProbe;
	///<summary>Event that happens when any ar environment capture probe item is updated</summary>
	public FTrackableEnvProbeDelegate OnUpdateTrackedEnvProbe;
	///<summary>Event that happens when any ar environment capture probe item is removed from the scene</summary>
	public FTrackableEnvProbeDelegate OnRemoveTrackedEnvProbe;
	///<summary>Event that happens when any new ar detected object item is added</summary>
	public FTrackableObjectDelegate OnAddTrackedObject;
	///<summary>Event that happens when any ar detected object item is updated</summary>
	public FTrackableObjectDelegate OnUpdateTrackedObject;
	///<summary>Event that happens when any ar detected object item is removed from the scene</summary>
	public FTrackableObjectDelegate OnRemoveTrackedObject;
}
