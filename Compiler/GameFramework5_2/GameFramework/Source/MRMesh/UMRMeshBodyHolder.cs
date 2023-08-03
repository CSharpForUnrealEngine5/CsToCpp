#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Because physics cooking uses GetOuter() to get the IInterface_CollisionDataProvider and provides no way to determine which physics body it</summary>
[CppInclude("MRMeshComponent.h")]
public partial class UMRMeshBodyHolder : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>BodySetup</summary>
	public UBodySetup BodySetup;
	///<summary>BodyInstance</summary>
	public FBodyInstance BodyInstance;
}
