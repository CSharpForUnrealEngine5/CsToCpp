namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>FuntionalAITest</summary>
[CppInclude("FunctionalAITest.h")]
public partial class AFunctionalAITest : AFunctionalAITestBase {
	public static UClass StaticClass() {return default;}
	///<summary>SpawnSets</summary>
	public TArray<FAITestSpawnSet> SpawnSets;
}
