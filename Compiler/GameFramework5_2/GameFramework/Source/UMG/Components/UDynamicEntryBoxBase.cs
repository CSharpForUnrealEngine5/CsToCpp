#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base for widgets that support a dynamic number of auto-generated entries at both design- and run-time.</summary>
[CppInclude("Components/DynamicEntryBoxBase.h")]
public partial class UDynamicEntryBoxBase : UWidget {
	public static UClass StaticClass() {return default;}
	///<summary>The padding to apply between entries in the box.</summary>
	public FVector2D EntrySpacing;
	///<summary>The looping sequence of entry paddings to apply as entries are created. Overlay boxes only. Ignores EntrySpacing if not empty.</summary>
	public TArray<FVector2D> SpacingPattern;
	///<summary>The type of box panel into which created entries are added. Some differences in functionality exist between each type.</summary>
	public EDynamicBoxType EntryBoxType;
	///<summary>Sizing rule to apply to generated entries. Horizontal/Vertical boxes only.</summary>
	public FSlateChildSize EntrySizeRule;
	///<summary>Horizontal alignment of generated entries. Horizontal/Vertical/Wrap boxes only.</summary>
	public EHorizontalAlignment EntryHorizontalAlignment;
	///<summary>Vertical alignment of generated entries. Horizontal/Vertical/Wrap boxes only.</summary>
	public EVerticalAlignment EntryVerticalAlignment;
	///<summary>The maximum size of each entry in the dominant axis of the box. Vertical/Horizontal boxes only.</summary>
	public int MaxElementSize;
	///<summary>Settings only relevant to RadialBox</summary>
	public FRadialBoxSettings RadialBoxSettings;
	///<summary>GetAllEntries</summary>
	public  TArray<UUserWidget> GetAllEntries() { return default; }
	///<summary>GetNumEntries</summary>
	public  int GetNumEntries() { return default; }
	///<summary>SetEntrySpacing</summary>
	public  void SetEntrySpacing(FVector2D InEntrySpacing) {}
	///<summary>SetRadialSettings</summary>
	public  void SetRadialSettings(FRadialBoxSettings InSettings) {}
	///<summary>EntryWidgetPool</summary>
	public FUserWidgetPool EntryWidgetPool;
}
