#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Passed in as params for Adding/Remove input contexts</summary>
[CppInclude("EnhancedInputSubsystemInterface.h")]
public partial struct FModifyContextOptions {
	public bool bIgnoreAllPressedKeysUntilRelease;
	public bool bForceImmediately;
}
