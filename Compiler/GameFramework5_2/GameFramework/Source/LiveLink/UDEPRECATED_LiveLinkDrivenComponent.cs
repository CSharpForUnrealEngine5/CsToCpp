#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LiveLinkDrivenComponent.h")]
///<summary>A component that applies data from Live Link to the owning actor</summary>
public partial class UDEPRECATED_LiveLinkDrivenComponent : UActorComponent {
// LiveLinkDrivenComponent
	public FLiveLinkSubjectName SubjectName;
	public string ActorTransformBone;
	public bool bModifyActorTransform;
	public bool bSetRelativeLocation;
}
