namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/MorphTarget.h")]
public partial class UMorphTarget : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>USkeletalMesh that this vertex animation works on.</summary>
	public USkeletalMesh BaseSkelMesh;
}
