namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A Skeleton virtual subject is an assembly of different subjects supporting the animation role</summary>
[CppInclude("LiveLinkAnimationVirtualSubject.h")]
public partial class ULiveLinkAnimationVirtualSubject : ULiveLinkVirtualSubject {
	public static UClass StaticClass() {return default;}
	///<summary>Whether to append SubjectName to each bones part of the virtual hierarchy</summary>
	public bool bAppendSubjectNameToBones;
}
