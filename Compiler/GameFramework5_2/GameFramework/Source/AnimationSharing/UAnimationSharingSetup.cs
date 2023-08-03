#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The Animation Sharing Setup asset contains all the information that will be shared across the specified Actors</summary>
[CppInclude("AnimationSharingSetup.h")]
public partial class UAnimationSharingSetup : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>SkeletonSetups</summary>
	public TArray<FPerSkeletonAnimationSharingSetup> SkeletonSetups;
	///<summary>ScalabilitySettings</summary>
	public FAnimationSharingScalability ScalabilitySettings;
}
