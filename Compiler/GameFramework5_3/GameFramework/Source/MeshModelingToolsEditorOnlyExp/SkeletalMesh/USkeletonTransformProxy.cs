namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>USkeletonTransformProxy is a derivation of UTransformProxy that manages several bones and update their transform individually.</summary>
[CppInclude("SkeletalMesh/SkeletonTransformProxy.h")]
public partial class USkeletonTransformProxy : UTransformProxy {
	public static UClass StaticClass() {return default;}
	///<summary>TransformMode</summary>
	public EToolContextCoordinateSystem TransformMode;
}
