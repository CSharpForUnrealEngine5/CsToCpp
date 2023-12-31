namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PersonaPreviewSceneAnimationController.h")]
public partial class UPersonaPreviewSceneAnimationController : UPersonaPreviewSceneController {
	public static UClass StaticClass() {return default;}
	///<summary>The preview animation to use</summary>
	public TSoftObjectPtr<UAnimationAsset> Animation;
}
