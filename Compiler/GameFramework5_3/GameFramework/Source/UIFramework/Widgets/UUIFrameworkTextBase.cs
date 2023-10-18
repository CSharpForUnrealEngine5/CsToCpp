namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Widgets/UIFTextBlock.h")]
public partial class UUIFrameworkTextBase : UUIFrameworkWidget {
	public static UClass StaticClass() {return default;}
	///<summary>GetText</summary>
	public FText GetText() { return default; }
	///<summary>SetTextColor</summary>
	public void SetTextColor(FLinearColor TextColor) {}
	///<summary>GetTextColor</summary>
	public FLinearColor GetTextColor() { return default; }
	///<summary>SetJustification</summary>
	public void SetJustification(ETextJustify Justification) {}
	///<summary>GetJustification</summary>
	public ETextJustify GetJustification() { return default; }
	///<summary>SetOverflowPolicy</summary>
	public void SetOverflowPolicy(ETextOverflowPolicy OverflowPolicy) {}
	///<summary>GetOverflowPolicy</summary>
	public ETextOverflowPolicy GetOverflowPolicy() { return default; }
	///<summary>OnRep_Message</summary>
	public void OnRep_Message() {}
	///<summary>OnRep_TextColor</summary>
	public void OnRep_TextColor() {}
	///<summary>OnRep_Justification</summary>
	public void OnRep_Justification() {}
	///<summary>OnRep_OverflowPolicy</summary>
	public void OnRep_OverflowPolicy() {}
	///<summary>Text</summary>
	public FText Text;
	///<summary>Message</summary>
	public FLocalizableMessage Message;
	///<summary>TextColor</summary>
	public FLinearColor TextColor;
	///<summary>Justification</summary>
	public ETextJustify Justification;
	///<summary>OverflowPolicy</summary>
	public ETextOverflowPolicy OverflowPolicy;
}
