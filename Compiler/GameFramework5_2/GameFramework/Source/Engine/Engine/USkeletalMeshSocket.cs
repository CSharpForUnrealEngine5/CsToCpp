#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/SkeletalMeshSocket.h")]
public partial class USkeletalMeshSocket : UObject {
// SkeletalMeshSocket
	public string SocketName;
	public string BoneName;
	public FVector RelativeLocation;
	public FRotator RelativeRotation;
	public FVector RelativeScale;
	public bool bForceAlwaysAnimated;
	public  FVector GetSocketLocation(USkeletalMeshComponent SkelComp) { return default; }
	public  void InitializeSocketFromLocation(USkeletalMeshComponent SkelComp,FVector WorldLocation,FVector WorldNormal) {}
}
