namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EditorValidatorSubsystem.h")]
public partial struct FValidateAssetsResults {
	public int NumChecked;
	public int NumValid;
	public int NumInvalid;
	public int NumSkipped;
	public int NumWarnings;
	public int NumUnableToValidate;
	public TMap<string,FValidateAssetsDetails> AssetsDetails;
}
