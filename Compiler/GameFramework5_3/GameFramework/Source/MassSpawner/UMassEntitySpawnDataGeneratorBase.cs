namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for Mass Entity Spawn Points Generator.</summary>
[CppInclude("MassEntitySpawnDataGeneratorBase.h")]
public partial class UMassEntitySpawnDataGeneratorBase : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>RandomSelectionSeed</summary>
	public int RandomSelectionSeed;
	///<summary>bUseCustomSeed</summary>
	public bool bUseCustomSeed;
}
