namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Used during asset renaming/duplication to specify class-specific package/group targets.</summary>
[CppInclude("Editor/UnrealEdEngine.h")]
public partial struct FClassMoveInfo {
	public string ClassName;
	public string PackageName;
	public string GroupName;
	public bool bActive;
}
