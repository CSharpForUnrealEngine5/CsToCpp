#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements a message for terminating the engine.</summary>
[CppInclude("EngineServiceMessages.h")]
public partial struct FEngineServiceTerminate {
	public string UserName;
}
