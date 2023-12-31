namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/TextRenderActor.h")]
public partial class ATextRenderActor : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>Component to render a text in 3d with a font</summary>
	public UTextRenderComponent TextRender;
	///<summary>Reference to the billboard component</summary>
	public UBillboardComponent SpriteComponent;
}
