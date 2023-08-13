namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LakeCollisionComponent.h")]
public partial class ULakeCollisionComponent : UPrimitiveComponent {
	public static UClass StaticClass() {return default;}
	///<summary>CachedBodySetup</summary>
	public UBodySetup CachedBodySetup;
	///<summary>BoxExtent</summary>
	public FVector BoxExtent;
}
