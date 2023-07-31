#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An audio component that also provides curves to drive animation</summary>
[CppInclude("AudioCurveSourceComponent.h")]
public partial class UAudioCurveSourceComponent : UAudioComponent {
	///<summary>Get the name that this curve source can be bound to by.</summary>
	public string CurveSourceBindingName;
	///<summary>Offset in time applied to audio position when evaluating curves</summary>
	public float CurveSyncOffset;
}
