namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/SynthComponent.h")]
public partial class USynthSound : USoundWaveProcedural {
	public static UClass StaticClass() {return default;}
	///<summary>OwningSynthComponent</summary>
	public TWeakObjectPtr<USynthComponent> OwningSynthComponent;
}
