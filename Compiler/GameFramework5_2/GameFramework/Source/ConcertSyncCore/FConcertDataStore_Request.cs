namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The request used as the base class for fetch or add and compare exchange</summary>
[CppInclude("ConcertDataStoreMessages.h")]
public partial struct FConcertDataStore_Request {
	public string Key;
	public string TypeName;
}
