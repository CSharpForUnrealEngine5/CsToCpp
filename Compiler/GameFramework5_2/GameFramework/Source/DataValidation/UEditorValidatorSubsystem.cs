#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EditorValidatorSubsystem.h")]
///<summary>UEditorValidatorSubsystem manages all the asset validation in the engine.</summary>
public partial class UEditorValidatorSubsystem : UEditorSubsystem {
// EditorValidatorSubsystem
	public  void AddValidator(UEditorValidatorBase InValidator) {}
	public  EDataValidationResult IsObjectValid(UObject InObject,TArray<string> ValidationErrors,TArray<string> ValidationWarnings,EDataValidationUsecase InValidationUsecase) { return default; }
	public  EDataValidationResult IsAssetValid(FAssetData AssetData,TArray<string> ValidationErrors,TArray<string> ValidationWarnings,EDataValidationUsecase InValidationUsecase) { return default; }
	public  int ValidateAssetsWithSettings(TArray<FAssetData> AssetDataList,FValidateAssetsSettings InSettings,FValidateAssetsResults OutResults) { return default; }
	public  int ValidateAssets(TArray<FAssetData> AssetDataList,bool bSkipExcludedDirectories/*=true*/,bool bShowIfNoFailures/*=true*/) { return default; }
	public TArray<FDirectoryPath> ExcludedDirectories;
	public bool bValidateOnSave;
	public TMap<string,UEditorValidatorBase> Validators;
	public bool bValidateAssetsWhileSavingForCook;
	public bool bAllowBlueprintValidators;
}
