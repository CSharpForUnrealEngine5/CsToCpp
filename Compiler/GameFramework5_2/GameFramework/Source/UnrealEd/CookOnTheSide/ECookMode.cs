#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CookOnTheSide/CookOnTheFlyServer.h")]
[CppEnumInNamespace]
public enum ECookMode {
	CookOnTheFly=0,
	CookOnTheFlyFromTheEditor=1,
	CookByTheBookFromTheEditor=2,
	CookByTheBook=3,
	CookWorker=4,
}
