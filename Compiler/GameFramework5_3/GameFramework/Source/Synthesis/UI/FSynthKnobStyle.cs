namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Represents the appearance of an SSynthKnob</summary>
[CppInclude("UI/SynthKnobStyle.h")]
public partial struct FSynthKnobStyle {
	public FSlateBrush LargeKnob;
	public FSlateBrush LargeKnobOverlay;
	public FSlateBrush MediumKnob;
	public FSlateBrush MediumKnobOverlay;
	public float MinValueAngle;
	public float MaxValueAngle;
	public ESynthKnobSize KnobSize;
}
