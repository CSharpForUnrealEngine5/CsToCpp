namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Camera/CameraLensEffectInterface.h")]
public partial class UCameraLensEffectInterface : UInterface {
	public static UClass StaticClass() {return default;}
	///<summary>GetParticleComponents</summary>
	public virtual TArray<UFXSystemComponent> GetParticleComponents() { return default; }
	///<summary>GetPrimaryParticleComponent</summary>
	public virtual UFXSystemComponent GetPrimaryParticleComponent() { return default; }
}
