namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Package map override, for blocking the creation of actor channels for specific actors (by detecting the actor class being created)</summary>
[CppInclude("Net/UnitTestPackageMap.h")]
public partial class UUnitTestPackageMap : UPackageMapClient {
	public static UClass StaticClass() {return default;}
	///<summary>Cached reference to the minimal client that owns this package map</summary>
	public UMinimalClient MinClient;
}
