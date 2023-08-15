namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/Engine.h")]
public partial struct FClassRedirect {
	public FName ObjectName;
	public FName OldClassName;
	public FName NewClassName;
	public FName OldSubobjName;
	public FName NewSubobjName;
	public FName NewClassClass;
	public FName NewClassPackage;
	public bool InstanceOnly;
}
