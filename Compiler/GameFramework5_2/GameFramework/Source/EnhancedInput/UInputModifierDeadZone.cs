namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Dead Zone</summary>
[CppInclude("InputModifiers.h")]
public partial class UInputModifierDeadZone : UInputModifier {
	public static UClass StaticClass() {return default;}
	///<summary>Threshold below which input is ignored</summary>
	public float LowerThreshold;
	///<summary>Threshold above which input is clamped to 1</summary>
	public float UpperThreshold;
	///<summary>Type</summary>
	public EDeadZoneType Type;
}
