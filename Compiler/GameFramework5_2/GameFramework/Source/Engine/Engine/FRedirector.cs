#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This is used for redirecting an old name to new name, such as for collision profiles</summary>
[CppInclude("Engine/EngineTypes.h")]
public partial struct FRedirector {
	public string OldName;
	public string NewName;
}
