namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LiveLinkPreviewController.h")]
public partial class ULiveLinkPreviewController : UPersonaPreviewSceneController {
	public static UClass StaticClass() {return default;}
	///<summary>SubjectName_DEPRECATED</summary>
	public FName SubjectName_DEPRECATED;
	///<summary>LiveLinkSubjectName</summary>
	public FLiveLinkSubjectName LiveLinkSubjectName;
	///<summary>bEnableCameraSync</summary>
	public bool bEnableCameraSync;
	///<summary>RetargetAsset</summary>
	public UClass RetargetAsset;
}
