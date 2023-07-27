#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LiveLinkComponent.h")]
///<summary>An actor component to enable accessing LiveLink data in Blueprints.</summary>
public partial class ULiveLinkComponent : UActorComponent {
// LiveLinkComponent
	public FLiveLinkTickSignature OnLiveLinkUpdated;
	public  void GetAvailableSubjectNames(TArray<string> SubjectNames) {}
	public  void GetSubjectData(string SubjectName,bool bSuccess,FSubjectFrameHandle SubjectFrameHandle) {}
	public  void GetSubjectDataAtWorldTime(string SubjectName,float WorldTime,bool bSuccess,FSubjectFrameHandle SubjectFrameHandle) {}
	public  void GetSubjectDataAtSceneTime(string SubjectName,FTimecode SceneTime,bool bSuccess,FSubjectFrameHandle SubjectFrameHandle) {}
}
