#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CommonActionWidget.h")]
///<summary>A widget that shows a platform-specific icon for the given input action.</summary>
public partial class UCommonActionWidget : UWidget {
// CommonActionWidget
	public  FSlateBrush GetIcon() { return default; }
	public  string GetDisplayText() { return default; }
	public  void SetEnhancedInputAction(UInputAction InInputAction) {}
	public  void SetInputAction(FDataTableRowHandle InputActionRow) {}
	public  void SetInputActions(TArray<FDataTableRowHandle> NewInputActions) {}
	public  void SetIconRimBrush(FSlateBrush InIconRimBrush) {}
	public  bool IsHeldAction() { return default; }
	public  void FOnInputMethodChanged(bool bUsingGamepad) {}
	public FOnInputMethodChanged OnInputMethodChanged;
	public FSlateBrush ProgressMaterialBrush;
	public string ProgressMaterialParam;
	public FSlateBrush IconRimBrush;
	public TArray<FDataTableRowHandle> InputActions;
	public UInputAction EnhancedInputAction;
	public FDataTableRowHandle InputActionDataRow_DEPRECATED;
	public UMaterialInstanceDynamic ProgressDynamicMaterial;
}
