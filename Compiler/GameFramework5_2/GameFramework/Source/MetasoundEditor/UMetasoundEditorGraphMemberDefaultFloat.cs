#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MetasoundEditorGraphMemberDefaults.h")]
public partial class UMetasoundEditorGraphMemberDefaultFloat : UMetasoundEditorGraphMemberDefaultLiteral {
// MetasoundEditorGraphMemberDefaultFloat
	public float Default;
	public bool ClampDefault;
	public FVector2D Range;
	public EMetasoundMemberDefaultWidget WidgetType;
	public byte WidgetOrientation;
	public EMetasoundMemberDefaultWidgetValueType WidgetValueType;
	public bool VolumeWidgetUseLinearOutput;
	public FVector2D VolumeWidgetDecibelRange;
}
