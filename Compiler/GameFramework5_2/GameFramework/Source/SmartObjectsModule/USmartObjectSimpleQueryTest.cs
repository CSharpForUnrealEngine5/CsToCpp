#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Simple test to run a query and draw the results.</summary>
[CppInclude("SmartObjectTestingActor.h")]
public partial class USmartObjectSimpleQueryTest : USmartObjectTest {
	public static UClass StaticClass() {return default;}
	///<summary>Request</summary>
	public FSmartObjectRequest Request;
	///<summary>Results</summary>
	public TArray<FSmartObjectRequestResult> Results;
}
