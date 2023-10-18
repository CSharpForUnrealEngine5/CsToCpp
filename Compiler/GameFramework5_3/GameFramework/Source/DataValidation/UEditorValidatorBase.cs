namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* The EditorValidatorBase is a class which verifies that an asset meets a specific ruleset.</summary>
[CppInclude("EditorValidatorBase.h")]
public partial class UEditorValidatorBase : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Override this to determine whether or not you can use this validator given this usecase</summary>
	public bool CanValidate(EDataValidationUsecase InUsecase) { return default; }
	///<summary>Override this to determine whether or not you can validate a given asset with this validator</summary>
	public bool CanValidateAsset(UObject InAsset) { return default; }
	///<summary>ValidateLoadedAsset</summary>
	public EDataValidationResult ValidateLoadedAsset(UObject InAsset,TArray<FText> ValidationErrors) { return default; }
	///<summary>AssetFails</summary>
	public void AssetFails(UObject InAsset,FText InMessage,TArray<FText> ValidationErrors) {}
	///<summary>AssetPasses</summary>
	public void AssetPasses(UObject InAsset) {}
	///<summary>AssetWarning</summary>
	public void AssetWarning(UObject InAsset,FText InMessage) {}
	///<summary>GetValidationResult</summary>
	public EDataValidationResult GetValidationResult() { return default; }
	///<summary>bIsEnabled</summary>
	public bool bIsEnabled;
}
