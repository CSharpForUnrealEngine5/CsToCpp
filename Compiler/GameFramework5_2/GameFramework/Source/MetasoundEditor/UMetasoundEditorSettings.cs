#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MetasoundEditorSettings.h")]
public partial class UMetasoundEditorSettings : UObject {
	///<summary>Whether to pin the MetaSound Patch asset type when creating new assets.</summary>
	public bool bPinMetaSoundPatchInAssetMenu;
	///<summary>Whether to pin the MetaSound Source asset type when creating new assets.</summary>
	public bool bPinMetaSoundSourceInAssetMenu;
	///<summary>Default author title to use when authoring a new</summary>
	public string DefaultAuthor;
	///<summary>Default pin type color</summary>
	public FLinearColor DefaultPinTypeColor;
	///<summary>Audio pin type color</summary>
	public FLinearColor AudioPinTypeColor;
	///<summary>Boolean pin type color</summary>
	public FLinearColor BooleanPinTypeColor;
	///<summary>Floating-point pin type color</summary>
	public FLinearColor FloatPinTypeColor;
	///<summary>Integer pin type color</summary>
	public FLinearColor IntPinTypeColor;
	///<summary>Object pin type color</summary>
	public FLinearColor ObjectPinTypeColor;
	///<summary>String pin type color</summary>
	public FLinearColor StringPinTypeColor;
	///<summary>Time pin type color</summary>
	public FLinearColor TimePinTypeColor;
	///<summary>Trigger pin type color</summary>
	public FLinearColor TriggerPinTypeColor;
	///<summary>WaveTable pin type color</summary>
	public FLinearColor WaveTablePinTypeColor;
	///<summary>Native node class title color</summary>
	public FLinearColor NativeNodeTitleColor;
	///<summary>Title color for references to MetaSound assets</summary>
	public FLinearColor AssetReferenceNodeTitleColor;
	///<summary>Input node title color</summary>
	public FLinearColor InputNodeTitleColor;
	///<summary>Output node title color</summary>
	public FLinearColor OutputNodeTitleColor;
	///<summary>Variable node title color</summary>
	public FLinearColor VariableNodeTitleColor;
	///<summary>Widget type to show on input nodes by default</summary>
	public EMetasoundMemberDefaultWidget DefaultInputWidgetType;
	///<summary>Settings for visualizing analyzed MetaSound connections</summary>
	public FMetasoundAnalyzerAnimationSettings AnalyzerAnimationSettings;
	///<summary>Determines which details view to show in Metasounds Editor</summary>
	public EMetasoundActiveDetailView DetailView;
}
