#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements the settings for Data Validation</summary>
[CppInclude("EditorValidatorSubsystem.h")]
public partial class UDataValidationSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Whether or not to validate assets on save</summary>
	public bool bValidateOnSave;
}
