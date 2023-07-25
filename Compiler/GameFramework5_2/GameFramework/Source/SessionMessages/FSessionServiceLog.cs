#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SessionServiceMessages.h")]
///<summary>Implements a message that contains a console log entry.</summary>
public partial struct FSessionServiceLog {
// SessionServiceLog
	public string Category;
	public string Data;
	public FGuid InstanceId;
	public double TimeSeconds;
	public byte Verbosity;
}
