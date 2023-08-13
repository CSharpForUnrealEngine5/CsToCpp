namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Manages centralized execution and tracking of data validation, as well as handling console commands,</summary>
[CppInclude("DataValidationManager.h")]
public partial class UDEPRECATED_DataValidationManager : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Directories to ignore for data validation. Useful for test assets</summary>
	public TArray<FDirectoryPath> ExcludedDirectories;
	///<summary>Rather it should validate assets on save inside the editor</summary>
	public bool bValidateOnSave;
	///<summary>The class to instantiate as the manager object. Defaults to this class but can be overridden</summary>
	public FSoftClassPath DataValidationManagerClassName;
}
