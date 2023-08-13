namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimationGraphSchema.h")]
public partial class UAnimationGraphSchema : UEdGraphSchema_K2 {
	public static UClass StaticClass() {return default;}
	///<summary>Common PinNames</summary>
	public string PN_SequenceName;
	///<summary>PC_Object+PSC_Sequence</summary>
	public string NAME_NeverAsPin;
	///<summary>NAME_PinHiddenByDefault</summary>
	public string NAME_PinHiddenByDefault;
	///<summary>NAME_PinShownByDefault</summary>
	public string NAME_PinShownByDefault;
	///<summary>NAME_AlwaysAsPin</summary>
	public string NAME_AlwaysAsPin;
	///<summary>NAME_CustomizeProperty</summary>
	public string NAME_CustomizeProperty;
	///<summary>NAME_OnEvaluate</summary>
	public string NAME_OnEvaluate;
	///<summary>DefaultEvaluationHandlerName</summary>
	public string DefaultEvaluationHandlerName;
}
