#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A base class for a simple camera shake.</summary>
[CppInclude("SimpleCameraShakePattern.h")]
public partial class USimpleCameraShakePattern : UCameraShakePattern {
	///<summary>Duration in seconds of this shake. Zero or less means infinite.</summary>
	public float Duration;
	///<summary>Blend-in time for this shake. Zero or less means no blend-in.</summary>
	public float BlendInTime;
	///<summary>Blend-out time for this shake. Zero or less means no blend-out.</summary>
	public float BlendOutTime;
}
