namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Factories/PhysicsAssetFactory.h")]
public partial class UPhysicsAssetFactory : UFactory {
	public static UClass StaticClass() {return default;}
	///<summary>The skeletal mesh with which to initialize this physics asset</summary>
	public USkeletalMesh TargetSkeletalMesh;
}
