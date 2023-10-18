namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Test-time SmartObjectSubsystem override, aimed at encapsulating test-time smart object instances and functionality</summary>
[CppInclude("SmartObjectTestTypes.h")]
public partial class USmartObjectTestSubsystem : USmartObjectSubsystem {
	public static UClass StaticClass() {return default;}
}
