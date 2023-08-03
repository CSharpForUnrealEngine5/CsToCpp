#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A widget that shows a platform-specific icon for the given input action.</summary>
[CppInclude("CommonActionWidget.h")]
public partial class UCommonActionWidget : UWidget {
	public static UClass StaticClass() {return default;}
	///<summary>End UWidet</summary>
	public  FSlateBrush GetIcon() { return default; }
	///<summary>GetDisplayText</summary>
	public  string GetDisplayText() { return default; }
	///<summary>SetEnhancedInputAction</summary>
	public  void SetEnhancedInputAction(UInputAction InInputAction) {}
	///<summary>SetInputAction</summary>
	public  void SetInputAction(FDataTableRowHandle InputActionRow) {}
	///<summary>SetInputActions</summary>
	public  void SetInputActions(TArray<FDataTableRowHandle> NewInputActions) {}
	///<summary>SetIconRimBrush</summary>
	public  void SetIconRimBrush(FSlateBrush InIconRimBrush) {}
	///<summary>IsHeldAction</summary>
	public  bool IsHeldAction() { return default; }
	///<summary>FOnInputMethodChanged</summary>
	public  void FOnInputMethodChanged(bool bUsingGamepad) {}
	///<summary>OnInputMethodChanged</summary>
	public FOnInputMethodChanged OnInputMethodChanged;
	///<summary>The material to use when showing held progress, the progress will be sent using the material parameter</summary>
	public FSlateBrush ProgressMaterialBrush;
	///<summary>The material parameter on ProgressMaterialBrush to update the held percentage.  This value will be 0..1.</summary>
	public string ProgressMaterialParam;
	///<summary>IconRimBrush</summary>
	public FSlateBrush IconRimBrush;
	///<summary>List all the input actions that this common action widget is intended to represent.  In some cases you might have multiple actions</summary>
	public TArray<FDataTableRowHandle> InputActions;
	///<summary>Input Action this common action widget is intended to represent. Optional if using EnhancedInputs</summary>
	public UInputAction EnhancedInputAction;
	///<summary>InputActionDataRow_DEPRECATED</summary>
	public FDataTableRowHandle InputActionDataRow_DEPRECATED;
	///<summary>ProgressDynamicMaterial</summary>
	public UMaterialInstanceDynamic ProgressDynamicMaterial;
}
