namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LiveLinkComponentController.h")]
public partial class ULiveLinkComponentController : UActorComponent {
	public static UClass StaticClass() {return default;}
	///<summary>SubjectRepresentation</summary>
	public FLiveLinkSubjectRepresentation SubjectRepresentation;
	///<summary>Controller_DEPRECATED</summary>
	public ULiveLinkControllerBase Controller_DEPRECATED;
	///<summary>Instanced controllers used to control the desired role</summary>
	public TMap<UClass,ULiveLinkControllerBase> ControllerMap;
	///<summary>bUpdateInEditor</summary>
	public bool bUpdateInEditor;
	///<summary>This Event is triggered any time new LiveLink data is available, including in the editor</summary>
	public FLiveLinkTickDelegate OnLiveLinkUpdated;
	///<summary>This Event is triggered any time the controller map is updated</summary>
	public FOnControllerMapUpdatedDelegate OnControllerMapUpdatedDelegate;
	///<summary>ComponentToControl_DEPRECATED</summary>
	public FComponentReference ComponentToControl_DEPRECATED;
	///<summary>If true, will not evaluate LiveLink if the attached actor is a spawnable in Sequencer</summary>
	public bool bDisableEvaluateLiveLinkWhenSpawnable;
	///<summary>If false, will not evaluate live link, effectively pausing.</summary>
	public bool bEvaluateLiveLink;
	///<summary>If true, will tick when the world is a preview (i.e Blueprint editors)</summary>
	public bool bUpdateInPreviewEditor;
	///<summary>Return Representation of Subject that is used in the controller</summary>
	public FLiveLinkSubjectRepresentation GetSubjectRepresentation() { return default; }
	///<summary>Set Representation of Subject that is used in the controller and update the controller map</summary>
	public void SetSubjectRepresentation(FLiveLinkSubjectRepresentation InSubjectRepresentation) {}
}
