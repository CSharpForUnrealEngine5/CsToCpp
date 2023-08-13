namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements a message that contains a notification or log output.</summary>
[CppInclude("EngineServiceMessages.h")]
public partial struct FEngineServiceNotification {
	public string Text;
	public double TimeSeconds;
}
