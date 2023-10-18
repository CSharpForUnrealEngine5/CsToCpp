namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ChaosClothAsset/ClothTransferSkinWeightsTool.h")]
public partial class UClothTransferSkinWeightsToolProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>SourceMesh</summary>
	public USkeletalMesh SourceMesh;
	///<summary>SourceMeshTranslation</summary>
	public FVector3d SourceMeshTranslation;
	///<summary>SourceMeshRotation</summary>
	public FVector3d SourceMeshRotation;
	///<summary>SourceMeshScale</summary>
	public FVector3d SourceMeshScale;
	///<summary>bHideSourceMesh</summary>
	public bool bHideSourceMesh;
}
