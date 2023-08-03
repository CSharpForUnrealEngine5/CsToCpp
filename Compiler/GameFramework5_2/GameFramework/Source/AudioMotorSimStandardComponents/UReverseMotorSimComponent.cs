#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Scales engine friction when reversing</summary>
[CppInclude("ReverseMotorSimComponent.h")]
public partial class UReverseMotorSimComponent : UAudioMotorSimComponent {
	public static UClass StaticClass() {return default;}
	///<summary>How much to scale engine friction by when reversing</summary>
	public float ReverseEngineResistanceModifier;
}
