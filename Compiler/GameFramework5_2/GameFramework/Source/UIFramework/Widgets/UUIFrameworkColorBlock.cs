#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Widgets/UIFColorBlock.h")]
public partial class UUIFrameworkColorBlock : UUIFrameworkWidget {
// UIFrameworkColorBlock
	public void SetColor(FLinearColor Tint) {}
	public FLinearColor GetColor() { return default; }
	public void SetDesiredSize(FVector2f DesiredSize) {}
	public FVector2f GetDesiredSize() { return default; }
	public void OnRep_Color() {}
	public void OnRep_DesiredSize() {}
	public FLinearColor Color;
	public FVector2f DesiredSize;
}
