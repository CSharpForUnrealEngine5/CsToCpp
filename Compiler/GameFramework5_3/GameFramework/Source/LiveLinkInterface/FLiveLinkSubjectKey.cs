namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Structure that identifies an individual subject</summary>
[CppInclude("LiveLinkTypes.h")]
public partial struct FLiveLinkSubjectKey {
	public FGuid Source;
	public FLiveLinkSubjectName SubjectName;
}
