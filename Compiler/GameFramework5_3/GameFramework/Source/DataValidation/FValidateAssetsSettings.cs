namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EditorValidatorSubsystem.h")]
public partial struct FValidateAssetsSettings {
	public bool bSkipExcludedDirectories;
	public bool bShowIfNoFailures;
	public bool bCollectPerAssetDetails;
	public EDataValidationUsecase ValidationUsecase;
}
