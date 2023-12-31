namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LiveLinkInstance.h")]
public partial class ULiveLinkInstance : UAnimInstance {
	public static UClass StaticClass() {return default;}
	///<summary>SetSubject</summary>
	public void SetSubject(FLiveLinkSubjectName SubjectName) {}
	///<summary>SetRetargetAsset</summary>
	public void SetRetargetAsset(UClass RetargetAsset) {}
	///<summary>Cache for GC</summary>
	public ULiveLinkRetargetAsset CurrentRetargetAsset;
}
