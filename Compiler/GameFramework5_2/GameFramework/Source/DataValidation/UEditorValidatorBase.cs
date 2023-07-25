#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EditorValidatorBase.h")]
///<summary>* The EditorValidatorBase is a class which verifies that an asset meets a specific ruleset.</summary>
public partial class UEditorValidatorBase : UObject {
// EditorValidatorBase
	public bool CanValidate(EDataValidationUsecase InUsecase) { return default; }
	public bool CanValidateAsset(UObject InAsset) { return default; }
	public EDataValidationResult ValidateLoadedAsset(UObject InAsset,TArray<string> ValidationErrors) { return default; }
	public void AssetFails(UObject InAsset,string InMessage,TArray<string> ValidationErrors) {}
	public void AssetPasses(UObject InAsset) {}
	public void AssetWarning(UObject InAsset,string InMessage) {}
	public EDataValidationResult GetValidationResult() { return default; }
	public bool bIsEnabled;
}
