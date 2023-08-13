namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds settings for the blueprint editor build promotion tests</summary>
[CppInclude("Tests/AutomationTestSettings.h")]
public partial struct FBlueprintEditorPromotionSettings {
	public FFilePath FirstMeshPath;
	public FFilePath SecondMeshPath;
	public FFilePath DefaultParticleAsset;
}
