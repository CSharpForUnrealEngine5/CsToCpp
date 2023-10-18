namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MassLWIConfigActor.h")]
public partial class AMassLWIConfigActor : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>DefaultConfig</summary>
	public FMassEntityConfig DefaultConfig;
	///<summary>PerClassConfigs</summary>
	public TMap<UClass,FMassEntityConfig> PerClassConfigs;
}
