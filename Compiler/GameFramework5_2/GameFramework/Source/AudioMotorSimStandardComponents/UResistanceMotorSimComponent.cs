namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Applys additional surface friction based on the angle of the vehicle&#39;s velocity</summary>
[CppInclude("ResistanceMotorSimComponent.h")]
public partial class UResistanceMotorSimComponent : UAudioMotorSimComponent {
	public static UClass StaticClass() {return default;}
	///<summary>How much to increase surface friction when driving straight up. Scales linearly based on driving angle.</summary>
	public float UpSpeedMaxFriction;
	///<summary>Minimum speed to apply this extra resistance</summary>
	public float MinSpeed;
	///<summary>Additional friction to add based on lateral speed</summary>
	public FRuntimeFloatCurve SideSpeedFrictionCurve;
}
