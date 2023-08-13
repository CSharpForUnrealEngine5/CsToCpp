namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Factories/SkeletonFactory.h")]
public partial class USkeletonFactory : UFactory {
	public static UClass StaticClass() {return default;}
	///<summary>The skeletal mesh with which to initialize this skeleton.</summary>
	public USkeletalMesh TargetSkeletalMesh;
}
