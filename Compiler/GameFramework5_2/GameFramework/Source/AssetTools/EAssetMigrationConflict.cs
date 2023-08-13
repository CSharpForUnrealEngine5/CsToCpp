namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("IAssetTools.h")]
public enum EAssetMigrationConflict {
	Skip=0,
	Overwrite=1,
	Cancel=2,
}
