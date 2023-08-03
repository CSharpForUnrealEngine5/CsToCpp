#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tests/RemoteControlTestData.h")]
public partial class URemoteControlTestObject : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>CStyleIntArray</summary>
	public int CStyleIntArray;
	///<summary>IntArray</summary>
	public TArray<int> IntArray;
	///<summary>FloatArray</summary>
	public TArray<float> FloatArray;
	///<summary>IntSet</summary>
	public TSet<int> IntSet;
	///<summary>IntMap</summary>
	public TMap<int,int> IntMap;
	///<summary>IntInnerStructMap</summary>
	public TMap<int,FRemoteControlTestInnerStruct> IntInnerStructMap;
	///<summary>StringColorMap</summary>
	public TMap<string,FColor> StringColorMap;
}
