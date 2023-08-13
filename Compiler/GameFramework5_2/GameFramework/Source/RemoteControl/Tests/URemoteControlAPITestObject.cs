namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tests/RemoteControlPropertyHandleTestData.h")]
public partial class URemoteControlAPITestObject : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>CStyleIntArray</summary>
	public int CStyleIntArray;
	///<summary>IntArray</summary>
	public TArray<int> IntArray;
	///<summary>StructOuterArray</summary>
	public TArray<FRemoteControlTestStructOuter> StructOuterArray;
	///<summary>IntSet</summary>
	public TSet<int> IntSet;
	///<summary>IntMap</summary>
	public TMap<int,int> IntMap;
	///<summary>StructOuterMap</summary>
	public TMap<int,FRemoteControlTestStructOuter> StructOuterMap;
	///<summary>StringColorMap</summary>
	public TMap<string,FColor> StringColorMap;
	///<summary>ArrayOfVectors</summary>
	public TArray<FVector> ArrayOfVectors;
	///<summary>StaticMeshComponent</summary>
	public UStaticMeshComponent StaticMeshComponent;
	///<summary>Int8Value</summary>
	public short Int8Value;
	///<summary>Int16Value</summary>
	public short Int16Value;
	///<summary>Int32Value</summary>
	public int Int32Value;
	///<summary>FloatValue</summary>
	public float FloatValue;
	///<summary>DoubleValue</summary>
	public double DoubleValue;
	///<summary>RemoteControlTestStructOuter</summary>
	public FRemoteControlTestStructOuter RemoteControlTestStructOuter;
	///<summary>StringValue</summary>
	public string StringValue;
	///<summary>NameValue</summary>
	public string NameValue;
	///<summary>TextValue</summary>
	public FText TextValue;
	///<summary>bValue</summary>
	public bool bValue;
	///<summary>ByteValue</summary>
	public byte ByteValue;
	///<summary>RemoteControlEnumByteValue</summary>
	public ERemoteControlEnum RemoteControlEnumByteValue;
	///<summary>RemoteControlEnumValue</summary>
	public ERemoteControlEnumClass RemoteControlEnumValue;
	///<summary>VectorValue</summary>
	public FVector VectorValue;
	///<summary>RotatorValue</summary>
	public FRotator RotatorValue;
	///<summary>ColorValue</summary>
	public FColor ColorValue;
	///<summary>LinearColorValue</summary>
	public FLinearColor LinearColorValue;
}
