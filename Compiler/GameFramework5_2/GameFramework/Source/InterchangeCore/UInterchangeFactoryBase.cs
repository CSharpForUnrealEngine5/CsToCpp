namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UObject asset factory implementation:</summary>
[CppInclude("InterchangeFactoryBase.h")]
public partial class UInterchangeFactoryBase : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>return the UClass this factory can create.</summary>
	public virtual UClass GetFactoryClass() { return default; }
	///<summary>Results</summary>
	public UInterchangeResultsContainer Results;
}
