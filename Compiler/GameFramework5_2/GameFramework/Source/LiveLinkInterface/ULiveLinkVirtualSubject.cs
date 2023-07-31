#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A Virtual subject is made up of one or more real subjects from a source</summary>
[CppInclude("LiveLinkVirtualSubject.h")]
public partial class ULiveLinkVirtualSubject : UObject {
	///<summary>The role the subject was build with.</summary>
	public UClass Role;
	///<summary>Names of the real subjects to combine into a virtual subject</summary>
	public TArray<FLiveLinkSubjectName> Subjects;
	///<summary>List of available translator the subject can use.</summary>
	public TArray<ULiveLinkFrameTranslator> FrameTranslators;
	///<summary>If enabled, rebroadcast this subject</summary>
	public bool bRebroadcastSubject;
}
