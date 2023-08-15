namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Proxy object used to display/edit bone transforms</summary>
[CppInclude("BoneProxy.h")]
public partial class UBoneProxy : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The name of the bone we have selected</summary>
	public FName BoneName;
	///<summary>Bone location</summary>
	public FVector Location;
	///<summary>Bone rotation</summary>
	public FRotator Rotation;
	///<summary>Bone scale</summary>
	public FVector Scale;
	///<summary>Bone reference location (local)</summary>
	public FVector ReferenceLocation;
	///<summary>Bone reference rotation (local)</summary>
	public FRotator ReferenceRotation;
	///<summary>Bone reference scale (local)</summary>
	public FVector ReferenceScale;
	///<summary>Mesh Location. Non zero when processing root motion</summary>
	public FVector MeshLocation;
	///<summary>Mesh Rotation. Non zero when processing root motion</summary>
	public FRotator MeshRotation;
	///<summary>Mesh Scale</summary>
	public FVector MeshScale;
	///<summary>The skeletal mesh component we glean our transform data from</summary>
	public TWeakObjectPtr<UDebugSkelMeshComponent> SkelMeshComponent;
}
