namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Example/MassVelocityRandomizerTrait.h")]
public partial class UMassRandomVelocityInitializer : UMassObserverProcessor {
	public static UClass StaticClass() {return default;}
	///<summary>MinSpeed</summary>
	public float MinSpeed;
	///<summary>The default max is set to 0 to enforce explicit configuration via SetParameters call.</summary>
	public float MaxSpeed;
	///<summary>bSetZComponent</summary>
	public bool bSetZComponent;
}
