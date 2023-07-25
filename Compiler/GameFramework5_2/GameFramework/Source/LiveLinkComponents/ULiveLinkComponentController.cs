#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LiveLinkComponentController.h")]
public partial class ULiveLinkComponentController : UActorComponent {
// LiveLinkComponentController
	public FLiveLinkSubjectRepresentation SubjectRepresentation;
	public ULiveLinkControllerBase Controller_DEPRECATED;
	public TMap<UClass,ULiveLinkControllerBase> ControllerMap;
	public bool bUpdateInEditor;
	public FLiveLinkTickDelegate OnLiveLinkUpdated;
	public FOnControllerMapUpdatedDelegate OnControllerMapUpdatedDelegate;
	public FComponentReference ComponentToControl_DEPRECATED;
	public bool bDisableEvaluateLiveLinkWhenSpawnable;
	public bool bEvaluateLiveLink;
	public bool bUpdateInPreviewEditor;
	public FLiveLinkSubjectRepresentation GetSubjectRepresentation() { return default; }
	public void SetSubjectRepresentation(FLiveLinkSubjectRepresentation InSubjectRepresentation) {}
}
