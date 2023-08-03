#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MetasoundEditorGraphMemberDefaults.h")]
public partial class UMetasoundEditorGraphMemberDefaultFloat : UMetasoundEditorGraphMemberDefaultLiteral {
	public static UClass StaticClass() {return default;}
	///<summary>Default</summary>
	public float Default;
	///<summary>ClampDefault</summary>
	public bool ClampDefault;
	///<summary>Range</summary>
	public FVector2D Range;
	///<summary>WidgetType</summary>
	public EMetasoundMemberDefaultWidget WidgetType;
	///<summary>WidgetOrientation</summary>
	public EOrientation WidgetOrientation;
	///<summary>WidgetValueType</summary>
	public EMetasoundMemberDefaultWidgetValueType WidgetValueType;
	///<summary>If true, output linear value. Otherwise, output dB value. The volume widget itself will always display the value in dB. The Default Value and Range are linear.</summary>
	public bool VolumeWidgetUseLinearOutput;
	///<summary>Range in decibels. This will be converted to the linear range in the Default Value category.</summary>
	public FVector2D VolumeWidgetDecibelRange;
}
