#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CodeProjectItem.h")]
///<summary>Types of project items. Note that the enum ordering determines the tree sorting</summary>
[CppEnumInNamespace]
public enum ECodeProjectItemType {
	Project=0,
	Folder=1,
	File=2,
}
