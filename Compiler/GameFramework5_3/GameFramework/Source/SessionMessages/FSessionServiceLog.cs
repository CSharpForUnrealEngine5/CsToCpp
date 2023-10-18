namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements a message that contains a console log entry.</summary>
[CppInclude("SessionServiceMessages.h")]
public partial struct FSessionServiceLog {
	public FName Category;
	public string Data;
	public FGuid InstanceId;
	public double TimeSeconds;
	public byte Verbosity;
}
