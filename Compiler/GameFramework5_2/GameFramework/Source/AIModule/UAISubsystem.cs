namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A class representing a common interface and behavior for AI subsystems</summary>
[CppInclude("AISubsystem.h")]
public partial class UAISubsystem : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>AISystem</summary>
	public UAISystem AISystem;
}
