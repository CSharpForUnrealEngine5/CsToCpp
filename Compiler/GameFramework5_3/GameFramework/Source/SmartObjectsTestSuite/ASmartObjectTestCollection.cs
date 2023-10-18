namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Test-time ASmartObjectPersistentCollection override, aimed at encapsulating test-time smart object instances and functionality</summary>
[CppInclude("SmartObjectTestTypes.h")]
public partial class ASmartObjectTestCollection : ASmartObjectPersistentCollection {
	public static UClass StaticClass() {return default;}
}
