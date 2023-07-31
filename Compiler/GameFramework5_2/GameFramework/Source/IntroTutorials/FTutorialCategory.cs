#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Category description</summary>
[CppInclude("EditorTutorial.h")]
public partial struct FTutorialCategory {
	public string Identifier;
	public string Title;
	public int SortOrder;
	public string Description;
	public string Icon;
	public FSoftObjectPath Texture;
}
