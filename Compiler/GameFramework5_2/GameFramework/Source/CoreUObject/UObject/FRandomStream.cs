namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Thread-safe random number generator that can be manually seeded.</summary>
[CppInclude("UObject/NoExportTypes.h")]
public partial struct FRandomStream {
	public int InitialSeed;
	public int Seed;
}
