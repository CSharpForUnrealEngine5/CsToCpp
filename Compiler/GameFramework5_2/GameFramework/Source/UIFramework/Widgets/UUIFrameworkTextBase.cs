#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Widgets/UIFTextBlock.h")]
public partial class UUIFrameworkTextBase : UUIFrameworkWidget {
	public static UClass StaticClass() {return default;}
	///<summary>SetText</summary>
	public  void SetText(string Text) {}
	///<summary>GetText</summary>
	public  string GetText() { return default; }
	///<summary>SetTextColor</summary>
	public  void SetTextColor(FLinearColor TextColor) {}
	///<summary>GetTextColor</summary>
	public  FLinearColor GetTextColor() { return default; }
	///<summary>SetJustification</summary>
	public  void SetJustification(ETextJustify Justification) {}
	///<summary>GetJustification</summary>
	public  ETextJustify GetJustification() { return default; }
	///<summary>SetOverflowPolicy</summary>
	public  void SetOverflowPolicy(ETextOverflowPolicy OverflowPolicy) {}
	///<summary>GetOverflowPolicy</summary>
	public  ETextOverflowPolicy GetOverflowPolicy() { return default; }
	///<summary>OnRep_Text</summary>
	public  void OnRep_Text() {}
	///<summary>OnRep_TextColor</summary>
	public  void OnRep_TextColor() {}
	///<summary>OnRep_Justification</summary>
	public  void OnRep_Justification() {}
	///<summary>OnRep_OverflowPolicy</summary>
	public  void OnRep_OverflowPolicy() {}
	///<summary>ExposeOnSpawn,</summary>
	public string Text;
	///<summary>TextColor</summary>
	public FLinearColor TextColor;
	///<summary>Justification</summary>
	public ETextJustify Justification;
	///<summary>OverflowPolicy</summary>
	public ETextOverflowPolicy OverflowPolicy;
}
