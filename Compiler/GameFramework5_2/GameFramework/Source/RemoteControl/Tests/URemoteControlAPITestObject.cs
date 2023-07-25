#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tests/RemoteControlPropertyHandleTestData.h")]
public partial class URemoteControlAPITestObject : UObject {
// RemoteControlAPITestObject
	public int CStyleIntArray;
	public TArray<int> IntArray;
	public TArray<FRemoteControlTestStructOuter> StructOuterArray;
	public TSet<int> IntSet;
	public TMap<int,int> IntMap;
	public TMap<int,FRemoteControlTestStructOuter> StructOuterMap;
	public TMap<string,FColor> StringColorMap;
	public TArray<FVector> ArrayOfVectors;
	public UStaticMeshComponent StaticMeshComponent;
	public short Int8Value;
	public short Int16Value;
	public int Int32Value;
	public float FloatValue;
	public double DoubleValue;
	public FRemoteControlTestStructOuter RemoteControlTestStructOuter;
	public string StringValue;
	public string NameValue;
	public string TextValue;
	public bool bValue;
	public byte ByteValue;
	public byte RemoteControlEnumByteValue;
	public ERemoteControlEnumClass RemoteControlEnumValue;
	public FVector VectorValue;
	public FRotator RotatorValue;
	public FColor ColorValue;
	public FLinearColor LinearColorValue;
}
