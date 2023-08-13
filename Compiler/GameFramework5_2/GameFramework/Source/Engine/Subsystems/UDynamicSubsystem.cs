namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Dynamic Subsystems auto populate/depopulate existing collections when modules are loaded and unloaded</summary>
[CppInclude("Subsystems/Subsystem.h")]
public partial class UDynamicSubsystem : USubsystem {
	public static UClass StaticClass() {return default;}
}
