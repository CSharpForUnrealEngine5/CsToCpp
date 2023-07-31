#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Example/MassVelocityRandomizerTrait.h")]
public partial class UMassVelocityRandomizerTrait : UMassEntityTraitBase {
	///<summary>The speed is expressed in UnrealUnits per second, which usually translates to 0.01m/s</summary>
	public float MinSpeed;
	///<summary>The speed is expressed in UnrealUnits per second, which usually translates to 0.01m/s</summary>
	public float MaxSpeed;
	///<summary>bSetZComponent</summary>
	public bool bSetZComponent;
}
