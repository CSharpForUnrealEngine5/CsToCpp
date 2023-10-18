namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A component that applies data from Live Link to the owning actor</summary>
[CppInclude("LiveLinkDrivenComponent.h")]
public partial class UDEPRECATED_LiveLinkDrivenComponent : UActorComponent {
	public static UClass StaticClass() {return default;}
	///<summary>The name of the live link subject to take data from</summary>
	public FLiveLinkSubjectName SubjectName;
	///<summary>The name of the bone to drive the actors transform with (if None then we will take the first bone)</summary>
	public FName ActorTransformBone;
	///<summary>Should the actors transform be driven by live link</summary>
	public bool bModifyActorTransform;
	///<summary>Should the transform from live link be treated as relative or world space</summary>
	public bool bSetRelativeLocation;
}
