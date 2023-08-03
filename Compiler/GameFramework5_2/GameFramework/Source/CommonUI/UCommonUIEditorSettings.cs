#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CommonUIEditorSettings.h")]
public partial class UCommonUIEditorSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Newly created CommonText Widgets will use this style.</summary>
	public TSoftObjectPtr<UClass> TemplateTextStyle;
	///<summary>Newly created CommonButton Widgets will use this style.</summary>
	public TSoftObjectPtr<UClass> TemplateButtonStyle;
	///<summary>Newly created CommonBorder Widgets will use this style.</summary>
	public TSoftObjectPtr<UClass> TemplateBorderStyle;
	///<summary>TemplateTextStyleClass</summary>
	public UClass TemplateTextStyleClass;
	///<summary>TemplateButtonStyleClass</summary>
	public UClass TemplateButtonStyleClass;
	///<summary>TemplateBorderStyleClass</summary>
	public UClass TemplateBorderStyleClass;
}
