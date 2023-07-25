#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataValidationManager.h")]
///<summary>Manages centralized execution and tracking of data validation, as well as handling console commands,</summary>
public partial class UDEPRECATED_DataValidationManager : UObject {
// DataValidationManager
	public TArray<FDirectoryPath> ExcludedDirectories;
	public bool bValidateOnSave;
	public FSoftClassPath DataValidationManagerClassName;
}
