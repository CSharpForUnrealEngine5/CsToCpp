#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements a message that is published to discover existing application sessions.</summary>
[CppInclude("SessionServiceMessages.h")]
public partial struct FSessionServicePing {
	public string UserName;
}
