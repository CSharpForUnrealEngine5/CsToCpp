namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A node in a named hierarchy</summary>
[CppInclude("NodeHierarchy.h")]
public partial struct FNodeObject {
	public FName Name;
	public FName ParentName;
}
