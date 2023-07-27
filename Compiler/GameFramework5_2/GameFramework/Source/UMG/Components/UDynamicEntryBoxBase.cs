#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/DynamicEntryBoxBase.h")]
///<summary>Base for widgets that support a dynamic number of auto-generated entries at both design- and run-time.</summary>
public partial class UDynamicEntryBoxBase : UWidget {
// DynamicEntryBoxBase
	public FVector2D EntrySpacing;
	public TArray<FVector2D> SpacingPattern;
	public EDynamicBoxType EntryBoxType;
	public FSlateChildSize EntrySizeRule;
	public byte EntryHorizontalAlignment;
	public byte EntryVerticalAlignment;
	public int MaxElementSize;
	public FRadialBoxSettings RadialBoxSettings;
	public  TArray<UUserWidget> GetAllEntries() { return default; }
	public  int GetNumEntries() { return default; }
	public  void SetEntrySpacing(FVector2D InEntrySpacing) {}
	public  void SetRadialSettings(FRadialBoxSettings InSettings) {}
	public FUserWidgetPool EntryWidgetPool;
}
