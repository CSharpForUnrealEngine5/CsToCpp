namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Widgets/UIFColorBlock.h")]
public partial class UUIFrameworkColorBlock : UUIFrameworkWidget {
	public static UClass StaticClass() {return default;}
	///<summary>SetColor</summary>
	public void SetColor(FLinearColor Tint) {}
	///<summary>GetColor</summary>
	public FLinearColor GetColor() { return default; }
	///<summary>SetDesiredSize</summary>
	public void SetDesiredSize(FVector2f DesiredSize) {}
	///<summary>GetDesiredSize</summary>
	public FVector2f GetDesiredSize() { return default; }
	///<summary>OnRep_Color</summary>
	public void OnRep_Color() {}
	///<summary>OnRep_DesiredSize</summary>
	public void OnRep_DesiredSize() {}
	///<summary>Color</summary>
	public FLinearColor Color;
	///<summary>DesiredSize</summary>
	public FVector2f DesiredSize;
}
