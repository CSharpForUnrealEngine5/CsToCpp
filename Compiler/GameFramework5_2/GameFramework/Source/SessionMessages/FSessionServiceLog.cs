#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements a message that contains a console log entry.</summary>
[CppInclude("SessionServiceMessages.h")]
public partial struct FSessionServiceLog {
	public string Category;
	public string Data;
	public FGuid InstanceId;
	public double TimeSeconds;
	public byte Verbosity;
}
