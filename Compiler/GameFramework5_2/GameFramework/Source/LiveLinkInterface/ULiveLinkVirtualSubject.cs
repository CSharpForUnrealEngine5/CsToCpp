#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LiveLinkVirtualSubject.h")]
///<summary>A Virtual subject is made up of one or more real subjects from a source</summary>
public partial class ULiveLinkVirtualSubject : UObject {
// LiveLinkVirtualSubject
	public UClass Role;
	public TArray<FLiveLinkSubjectName> Subjects;
	public TArray<ULiveLinkFrameTranslator> FrameTranslators;
	public bool bRebroadcastSubject;
}
