namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>FAITestSpawnSetBase</summary>
[CppInclude("FunctionalAITest.h")]
public partial struct FAITestSpawnSetBase {
	public FName Name;
	public bool bEnabled;
	public AActor FallbackSpawnLocation;
}
