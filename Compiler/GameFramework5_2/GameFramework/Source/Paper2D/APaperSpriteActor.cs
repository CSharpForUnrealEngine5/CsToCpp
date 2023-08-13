namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An instance of a UPaperSprite in a level.</summary>
[CppInclude("PaperSpriteActor.h")]
public partial class APaperSpriteActor : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>RenderComponent</summary>
	public UPaperSpriteComponent RenderComponent;
}
