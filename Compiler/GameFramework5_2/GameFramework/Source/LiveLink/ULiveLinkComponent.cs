#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An actor component to enable accessing LiveLink data in Blueprints.</summary>
[CppInclude("LiveLinkComponent.h")]
public partial class ULiveLinkComponent : UActorComponent {
	///<summary>This Event is triggered any time new LiveLink data is available, including in the editor</summary>
	public FLiveLinkTickSignature OnLiveLinkUpdated;
	///<summary>GetAvailableSubjectNames</summary>
	public  void GetAvailableSubjectNames(TArray<string> SubjectNames) {}
	///<summary>GetSubjectData</summary>
	public  void GetSubjectData(string SubjectName,bool bSuccess,FSubjectFrameHandle SubjectFrameHandle) {}
	///<summary>GetSubjectDataAtWorldTime</summary>
	public  void GetSubjectDataAtWorldTime(string SubjectName,float WorldTime,bool bSuccess,FSubjectFrameHandle SubjectFrameHandle) {}
	///<summary>GetSubjectDataAtSceneTime</summary>
	public  void GetSubjectDataAtSceneTime(string SubjectName,FTimecode SceneTime,bool bSuccess,FSubjectFrameHandle SubjectFrameHandle) {}
}
