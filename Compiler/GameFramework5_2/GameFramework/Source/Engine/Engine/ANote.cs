#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/Note.h")]
public partial class ANote : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>Text</summary>
	public string Text;
	///<summary>SpriteComponent</summary>
	public UBillboardComponent SpriteComponent;
	///<summary>Reference to arrow visualization component</summary>
	public UArrowComponent ArrowComponent;
}
