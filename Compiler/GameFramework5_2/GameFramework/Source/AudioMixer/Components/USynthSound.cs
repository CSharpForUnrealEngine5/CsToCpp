#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/SynthComponent.h")]
public partial class USynthSound : USoundWaveProcedural {
	public static UClass StaticClass() {return default;}
	///<summary>OwningSynthComponent</summary>
	public TWeakObjectPtr<USynthComponent> OwningSynthComponent;
}
