namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Subsystems are auto instanced classes that share the lifetime of certain engine constructs</summary>
[CppInclude("Subsystems/Subsystem.h")]
public partial class USubsystem : UObject {
	public static UClass StaticClass() {return default;}
}
