namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UObject/NoExportTypes.h")]
///<summary>Enum controlling when to emit property change notifications when setting a property value.</summary>
public enum EPropertyAccessChangeNotifyMode {
	Default=0,
	Never=1,
	Always=2,
}
