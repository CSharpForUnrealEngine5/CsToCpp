#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/TextRenderActor.h")]
public partial class ATextRenderActor : AActor {
	///<summary>Component to render a text in 3d with a font</summary>
	public UTextRenderComponent TextRender;
	///<summary>Reference to the billboard component</summary>
	public UBillboardComponent SpriteComponent;
}
