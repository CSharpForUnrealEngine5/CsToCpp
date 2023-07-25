#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MetasoundEditorSettings.h")]
public partial class UMetasoundEditorSettings : UObject {
// MetasoundEditorSettings
	public bool bPinMetaSoundPatchInAssetMenu;
	public bool bPinMetaSoundSourceInAssetMenu;
	public string DefaultAuthor;
	public FLinearColor DefaultPinTypeColor;
	public FLinearColor AudioPinTypeColor;
	public FLinearColor BooleanPinTypeColor;
	public FLinearColor FloatPinTypeColor;
	public FLinearColor IntPinTypeColor;
	public FLinearColor ObjectPinTypeColor;
	public FLinearColor StringPinTypeColor;
	public FLinearColor TimePinTypeColor;
	public FLinearColor TriggerPinTypeColor;
	public FLinearColor WaveTablePinTypeColor;
	public FLinearColor NativeNodeTitleColor;
	public FLinearColor AssetReferenceNodeTitleColor;
	public FLinearColor InputNodeTitleColor;
	public FLinearColor OutputNodeTitleColor;
	public FLinearColor VariableNodeTitleColor;
	public EMetasoundMemberDefaultWidget DefaultInputWidgetType;
	public FMetasoundAnalyzerAnimationSettings AnalyzerAnimationSettings;
	public EMetasoundActiveDetailView DetailView;
}
