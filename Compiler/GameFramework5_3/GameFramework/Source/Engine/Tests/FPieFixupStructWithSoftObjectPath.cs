namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tests/PieFixupTestObjects.h")]
public partial struct FPieFixupStructWithSoftObjectPath {
	public FSoftObjectPath Path;
	public TSoftObjectPtr<AActor> TypedPtr;
}
