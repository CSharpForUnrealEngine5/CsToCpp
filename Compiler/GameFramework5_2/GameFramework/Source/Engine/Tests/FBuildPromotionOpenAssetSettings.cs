#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds settings for the open assets stage of the build promotion test</summary>
[CppInclude("Tests/AutomationTestSettings.h")]
public partial struct FBuildPromotionOpenAssetSettings {
	public FFilePath BlueprintAsset;
	public FFilePath MaterialAsset;
	public FFilePath ParticleSystemAsset;
	public FFilePath SkeletalMeshAsset;
	public FFilePath StaticMeshAsset;
	public FFilePath TextureAsset;
}
