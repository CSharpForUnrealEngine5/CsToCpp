namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements a message for terminating the engine.</summary>
[CppInclude("EngineServiceMessages.h")]
public partial struct FEngineServiceTerminate {
	public string UserName;
}
