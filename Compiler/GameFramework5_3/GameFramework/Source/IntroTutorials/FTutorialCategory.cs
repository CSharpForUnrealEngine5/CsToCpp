namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Category description</summary>
[CppInclude("EditorTutorial.h")]
public partial struct FTutorialCategory {
	public string Identifier;
	public FText Title;
	public int SortOrder;
	public FText Description;
	public string Icon;
	public FSoftObjectPath Texture;
}
