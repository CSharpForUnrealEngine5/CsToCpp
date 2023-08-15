namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This is used for redirecting an old name to new name, such as for collision profiles</summary>
[CppInclude("Engine/EngineTypes.h")]
public partial struct FRedirector {
	public FName OldName;
	public FName NewName;
}
