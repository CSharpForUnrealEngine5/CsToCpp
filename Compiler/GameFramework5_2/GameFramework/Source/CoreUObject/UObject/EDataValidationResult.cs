#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UObject/NoExportTypes.h")]
///<summary>Enum used by DataValidation plugin to see if an asset has been validated for correctness (mirrored in UObjectGlobals.h)</summary>
public enum EDataValidationResult {
	Invalid=0,
	Valid=1,
	NotValidated=2,
}
