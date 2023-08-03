#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A class representing a common interface and behavior for AI subsystems</summary>
[CppInclude("AISubsystem.h")]
public partial class UAISubsystem : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>AISystem</summary>
	public UAISystem AISystem;
}
