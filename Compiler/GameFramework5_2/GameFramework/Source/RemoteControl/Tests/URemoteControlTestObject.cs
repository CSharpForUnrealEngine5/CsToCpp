#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tests/RemoteControlTestData.h")]
public partial class URemoteControlTestObject : UObject {
// RemoteControlTestObject
	public int CStyleIntArray;
	public TArray<int> IntArray;
	public TArray<float> FloatArray;
	public TSet<int> IntSet;
	public TMap<int,int> IntMap;
	public TMap<int,FRemoteControlTestInnerStruct> IntInnerStructMap;
	public TMap<string,FColor> StringColorMap;
}
