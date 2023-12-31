namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Asset container for VREditor.</summary>
[CppInclude("ConcertAssetContainer.h")]
public partial class UConcertAssetContainer : UDataAsset {
	public static UClass StaticClass() {return default;}
	///<summary>Meshes</summary>
	public UStaticMesh GenericDesktopMesh;
	///<summary>GenericHMDMesh</summary>
	public UStaticMesh GenericHMDMesh;
	///<summary>VivePreControllerMesh</summary>
	public UStaticMesh VivePreControllerMesh;
	///<summary>OculusControllerMesh</summary>
	public UStaticMesh OculusControllerMesh;
	///<summary>GenericControllerMesh</summary>
	public UStaticMesh GenericControllerMesh;
	///<summary>LaserPointerMesh</summary>
	public UStaticMesh LaserPointerMesh;
	///<summary>LaserPointerEndMesh</summary>
	public UStaticMesh LaserPointerEndMesh;
	///<summary>LaserPointerStartMesh</summary>
	public UStaticMesh LaserPointerStartMesh;
	///<summary>Materials</summary>
	public UMaterialInterface PresenceMaterial;
	///<summary>TextMaterial</summary>
	public UMaterialInterface TextMaterial;
	///<summary>HeadMaterial</summary>
	public UMaterialInterface HeadMaterial;
	///<summary>LaserCoreMaterial</summary>
	public UMaterialInterface LaserCoreMaterial;
	///<summary>LaserMaterial</summary>
	public UMaterialInterface LaserMaterial;
	///<summary>PresenceFadeMaterial</summary>
	public UMaterialInterface PresenceFadeMaterial;
}
