namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Factories/MaterialImportHelpers.h")]
public enum EMaterialSearchLocation {
	Local=0,
	UnderParent=1,
	UnderRoot=2,
	AllAssets=3,
	DoNotSearch=4,
}
