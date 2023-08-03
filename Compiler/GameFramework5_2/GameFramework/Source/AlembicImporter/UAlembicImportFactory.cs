#pragma warning disable CS8618,CS8603,CS1587,CS1591
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
