namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UnrealEd/ObjectToolsTests.h")]
public partial class UObjectToolsTestObject : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>StrongReference</summary>
	public UObject StrongReference;
	///<summary>WeakReference</summary>
	public TWeakObjectPtr<UObject> WeakReference;
}
