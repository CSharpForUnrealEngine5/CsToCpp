#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MRMeshComponent.h")]
///<summary>Because physics cooking uses GetOuter() to get the IInterface_CollisionDataProvider and provides no way to determine which physics body it</summary>
public partial class UMRMeshBodyHolder : UObject {
// MRMeshBodyHolder
	public UBodySetup BodySetup;
	public FBodyInstance BodyInstance;
}
