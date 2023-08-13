namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/SkeletalMeshSocket.h")]
public partial class USkeletalMeshSocket : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Defines a named attachment location on the USkeletalMesh.</summary>
	public string SocketName;
	///<summary>BoneName</summary>
	public string BoneName;
	///<summary>RelativeLocation</summary>
	public FVector RelativeLocation;
	///<summary>RelativeRotation</summary>
	public FRotator RelativeRotation;
	///<summary>RelativeScale</summary>
	public FVector RelativeScale;
	///<summary>If true then the hierarchy of bones this socket is attached to will always be</summary>
	public bool bForceAlwaysAnimated;
	///<summary>GetSocketLocation</summary>
	public FVector GetSocketLocation(USkeletalMeshComponent SkelComp) { return default; }
	///<summary>Sets BoneName, RelativeLocation and RelativeRotation based on closest bone to WorldLocation and WorldNormal</summary>
	public void InitializeSocketFromLocation(USkeletalMeshComponent SkelComp,FVector WorldLocation,FVector WorldNormal) {}
}
