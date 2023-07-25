#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BoneProxy.h")]
///<summary>Proxy object used to display/edit bone transforms</summary>
public partial class UBoneProxy : UObject {
// BoneProxy
	public string BoneName;
	public FVector Location;
	public FRotator Rotation;
	public FVector Scale;
	public FVector ReferenceLocation;
	public FRotator ReferenceRotation;
	public FVector ReferenceScale;
	public FVector MeshLocation;
	public FRotator MeshRotation;
	public FVector MeshScale;
	public TWeakObjectPtr<UDebugSkelMeshComponent> SkelMeshComponent;
}
