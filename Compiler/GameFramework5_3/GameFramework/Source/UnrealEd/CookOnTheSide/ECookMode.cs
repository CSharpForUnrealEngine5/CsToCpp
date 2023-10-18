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
