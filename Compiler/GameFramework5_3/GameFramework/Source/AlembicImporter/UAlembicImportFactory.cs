namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AlembicImportFactory.h")]
public partial class UAlembicImportFactory : UFactory {
	public static UClass StaticClass() {return default;}
	///<summary>Object used to show import options for Alembic</summary>
	public UAbcImportSettings ImportSettings;
	///<summary>bShowOption</summary>
	public bool bShowOption;
}
