namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds settings for the material editor build promotion tests</summary>
[CppInclude("Tests/AutomationTestSettings.h")]
public partial struct FMaterialEditorPromotionSettings {
	public FFilePath DefaultMaterialAsset;
	public FFilePath DefaultDiffuseTexture;
	public FFilePath DefaultNormalTexture;
}
