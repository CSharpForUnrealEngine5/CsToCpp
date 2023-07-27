#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/ListViewBase.h")]
///<summary>Bare-bones base class to make creating custom UListView widgets easier.</summary>
public partial class UListViewBase : UWidget {
// ListViewBase
	public  TArray<UUserWidget> GetDisplayedEntryWidgets() { return default; }
	public  float GetScrollOffset() { return default; }
	public  void RegenerateAllEntries() {}
	public  void ScrollToTop() {}
	public  void ScrollToBottom() {}
	public  void SetScrollOffset(float InScrollOffset) {}
	public  void SetWheelScrollMultiplier(float NewWheelScrollMultiplier) {}
	public  void SetScrollbarVisibility(ESlateVisibility InVisibility) {}
	public  void RequestRefresh() {}
	public FOnListEntryGeneratedDynamic BP_OnEntryGenerated;
	public UClass EntryWidgetClass;
	public float WheelScrollMultiplier;
	public bool bEnableScrollAnimation;
	public bool AllowOverscroll;
	public bool bEnableRightClickScrolling;
	public bool bEnableFixedLineOffset;
	public float FixedLineScrollOffset;
	public bool bAllowDragging;
	public FOnListEntryReleasedDynamic BP_OnEntryReleased;
	public int NumDesignerPreviewEntries;
	public FUserWidgetPool EntryWidgetPool;
}
