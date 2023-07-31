#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LiveLinkInstance.h")]
public partial class ULiveLinkInstance : UAnimInstance {
	///<summary>SetSubject</summary>
	public  void SetSubject(FLiveLinkSubjectName SubjectName) {}
	///<summary>SetRetargetAsset</summary>
	public  void SetRetargetAsset(UClass RetargetAsset) {}
	///<summary>Cache for GC</summary>
	public ULiveLinkRetargetAsset CurrentRetargetAsset;
}
