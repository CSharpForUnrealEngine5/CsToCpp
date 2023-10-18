namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UObject/NoExportTypes.h")]
public partial struct FTestUndeclaredScriptStructObjectReferencesTest {
	public UObject StrongObjectPointer;
	public TSoftObjectPtr<UObject> SoftObjectPointer;
	public FSoftObjectPath SoftObjectPath;
	public TWeakObjectPtr<UObject> WeakObjectPointer;
}
