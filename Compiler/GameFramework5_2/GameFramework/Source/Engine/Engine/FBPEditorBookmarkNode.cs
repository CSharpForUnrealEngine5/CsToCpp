namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Bookmark node info</summary>
[CppInclude("Engine/Blueprint.h")]
public partial struct FBPEditorBookmarkNode {
	public FGuid NodeGuid;
	public FGuid ParentGuid;
	public FText DisplayName;
}
