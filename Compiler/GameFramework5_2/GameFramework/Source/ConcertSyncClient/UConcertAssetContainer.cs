#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertAssetContainer.h")]
///<summary>Asset container for VREditor.</summary>
public partial class UConcertAssetContainer : UDataAsset {
// ConcertAssetContainer
	public UStaticMesh GenericDesktopMesh;
	public UStaticMesh GenericHMDMesh;
	public UStaticMesh VivePreControllerMesh;
	public UStaticMesh OculusControllerMesh;
	public UStaticMesh GenericControllerMesh;
	public UStaticMesh LaserPointerMesh;
	public UStaticMesh LaserPointerEndMesh;
	public UStaticMesh LaserPointerStartMesh;
	public UMaterialInterface PresenceMaterial;
	public UMaterialInterface TextMaterial;
	public UMaterialInterface HeadMaterial;
	public UMaterialInterface LaserCoreMaterial;
	public UMaterialInterface LaserMaterial;
	public UMaterialInterface PresenceFadeMaterial;
}
