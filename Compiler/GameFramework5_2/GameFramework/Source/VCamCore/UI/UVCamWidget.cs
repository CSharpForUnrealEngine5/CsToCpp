#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* A wrapper widget class that contains a set of VCam Connections</summary>
[CppInclude("UI/VCamWidget.h")]
public partial class UVCamWidget : UUserWidget {
	public static UClass StaticClass() {return default;}
	///<summary>* The VCam Connections associated with this Widget</summary>
	public TMap<string,FVCamConnection> Connections;
	///<summary>* Determines whether this widget will be automatically registered to receive input when the connections are initialized</summary>
	public bool bRegisterForInput;
	///<summary>* If this widget is registered for input then this input mapping context will be added to the input system</summary>
	public UInputMappingContext InputMappingContext;
	///<summary>* If this widget is registered for input then this property defines the priority that the input mapping context is added at</summary>
	public int InputContextPriority;
	///<summary>FConnectionsReinitializedDelegate_Blueprint</summary>
	public  void FConnectionsReinitializedDelegate_Blueprint() {}
	///<summary>Called when ReinitializeConnections is called.</summary>
	public FConnectionsReinitializedDelegate_Blueprint OnPostConnectionsReinitializedDelegate_Blueprint;
	///<summary>* Event called when a specific connection has been updated</summary>
	public  void OnConnectionUpdated(string ConnectionName,bool bDidConnectSuccessfully,string ModifierConnectionPointName,UVCamModifier ConnectedModifier,UInputAction ConnectedAction) {}
	///<summary>* Event called after all connections have been initialized or reinitialized</summary>
	public  void PostConnectionsInitialized() {}
	///<summary>* Attempts to use the cached VCam Component to initialize the connections</summary>
	public  bool ReinitializeConnections() { return default; }
	///<summary>* Looks through the set of Connections on this widget and if a matching connection name is found will attempt to update the connection target.</summary>
	public  void UpdateConnectionTargets(TMap<string,FVCamConnectionTargetSettings> NewConnectionTargets,bool bReinitializeOnSuccessfulUpdate,EConnectionUpdateResult Result) {}
	///<summary>OnInitializeConnections</summary>
	public  void OnInitializeConnections(UVCamComponent VCam) {}
	///<summary>* Cached pointer to the VCam Component that owns this VCam Widget</summary>
	public UVCamComponent VCamComponent;
}
