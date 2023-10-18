namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AndroidRuntimeSettings.h")]
///<summary>The default install location for the application</summary>
[CppEnumInNamespace]
public enum EAndroidInstallLocation {
	InternalOnly=0,
	PreferExternal=1,
	Auto=2,
}
