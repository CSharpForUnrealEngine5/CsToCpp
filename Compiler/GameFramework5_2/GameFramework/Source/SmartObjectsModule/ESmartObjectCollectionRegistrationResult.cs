#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SmartObjectSubsystem.h")]
///<summary>Result code indicating if the Collection was successfully registered or why it was not.</summary>
public enum ESmartObjectCollectionRegistrationResult {
	Failed_InvalidCollection=0,
	Failed_AlreadyRegistered=1,
	Failed_NotFromPersistentLevel=2,
	Succeeded=3,
}
