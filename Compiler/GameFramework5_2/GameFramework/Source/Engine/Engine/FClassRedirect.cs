namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/Engine.h")]
public partial struct FClassRedirect {
	public string ObjectName;
	public string OldClassName;
	public string NewClassName;
	public string OldSubobjName;
	public string NewSubobjName;
	public string NewClassClass;
	public string NewClassPackage;
	public bool InstanceOnly;
}
