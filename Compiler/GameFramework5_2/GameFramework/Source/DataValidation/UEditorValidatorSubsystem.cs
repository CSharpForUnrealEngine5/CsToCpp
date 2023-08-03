#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UEditorValidatorSubsystem manages all the asset validation in the engine.</summary>
[CppInclude("EditorValidatorSubsystem.h")]
public partial class UEditorValidatorSubsystem : UEditorSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>* Adds a validator to the list, making sure it is a unique instance</summary>
	public  void AddValidator(UEditorValidatorBase InValidator) {}
	///<summary>@return Returns Valid if the object contains valid data; returns Invalid if the object contains invalid data; returns NotValidated if no validations was performed on the object</summary>
	public  EDataValidationResult IsObjectValid(UObject InObject,TArray<string> ValidationErrors,TArray<string> ValidationWarnings,EDataValidationUsecase InValidationUsecase) { return default; }
	///<summary>@return Returns Valid if the object pointed to by AssetData contains valid data; returns Invalid if the object contains invalid data or does not exist; returns NotValidated if no validations was performed on the object</summary>
	public  EDataValidationResult IsAssetValid(FAssetData AssetData,TArray<string> ValidationErrors,TArray<string> ValidationWarnings,EDataValidationUsecase InValidationUsecase) { return default; }
	///<summary>Called to validate assets from either the UI or a commandlet</summary>
	public  int ValidateAssetsWithSettings(TArray<FAssetData> AssetDataList,FValidateAssetsSettings InSettings,FValidateAssetsResults OutResults) { return default; }
	///<summary>ValidateAssets</summary>
	public  int ValidateAssets(TArray<FAssetData> AssetDataList,bool bSkipExcludedDirectories/*=true*/,bool bShowIfNoFailures/*=true*/) { return default; }
	///<summary>Directories to ignore for data validation. Useful for test assets</summary>
	public TArray<FDirectoryPath> ExcludedDirectories;
	///<summary>Whether it should validate assets on save inside the editor</summary>
	public bool bValidateOnSave;
	///<summary>Validators</summary>
	public TMap<string,UEditorValidatorBase> Validators;
	///<summary>Specifies whether or not to validate assets on save when saving for a cook</summary>
	public bool bValidateAssetsWhileSavingForCook;
	///<summary>Specifies whether or not to allow Blueprint validators</summary>
	public bool bAllowBlueprintValidators;
}
