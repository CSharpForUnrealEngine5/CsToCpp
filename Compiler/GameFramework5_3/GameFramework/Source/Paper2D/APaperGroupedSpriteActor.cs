namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A group of sprites that will be rendered and culled as a single unit</summary>
[CppInclude("PaperGroupedSpriteActor.h")]
public partial class APaperGroupedSpriteActor : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>RenderComponent</summary>
	public UPaperGroupedSpriteComponent RenderComponent;
}
