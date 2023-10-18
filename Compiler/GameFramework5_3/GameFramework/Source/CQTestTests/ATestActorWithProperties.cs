namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TestActorWithProperties.h")]
public partial class ATestActorWithProperties : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>BoolProperty</summary>
	public bool BoolProperty;
	///<summary>ByteProperty</summary>
	public byte ByteProperty;
	///<summary>Int8Property</summary>
	public short Int8Property;
	///<summary>UInt8Property</summary>
	public byte UInt8Property;
	///<summary>UInt16Property</summary>
	public ushort UInt16Property;
	///<summary>Int16Property</summary>
	public short Int16Property;
	///<summary>UInt32Property</summary>
	public uint UInt32Property;
	///<summary>Int64Property</summary>
	public long Int64Property;
	///<summary>UInt64Property</summary>
	public ulong UInt64Property;
	///<summary>StructProperty</summary>
	public FTestStructWithProperties StructProperty;
	///<summary>FloatProperty</summary>
	public float FloatProperty;
	///<summary>DoubleProperty</summary>
	public double DoubleProperty;
	///<summary>Int32Property</summary>
	public int Int32Property;
	///<summary>TestTObjectPtrProperty</summary>
	public UAnimSequence TestTObjectPtrProperty;
	///<summary>InterfaceProperty</summary>
	public UObject InterfaceProperty;
	///<summary>NameProperty</summary>
	public FName NameProperty;
	///<summary>ArrayProperty</summary>
	public TArray<int> ArrayProperty;
	///<summary>MapProperty</summary>
	public TMap<int,int> MapProperty;
	///<summary>SetProperty</summary>
	public TSet<int> SetProperty;
	///<summary>VectorProperty</summary>
	public FVector VectorProperty;
	///<summary>Uint8EnumProperty</summary>
	public ETestUint8 Uint8EnumProperty;
	///<summary>Int8EnumProperty</summary>
	public ETestInt8 Int8EnumProperty;
	///<summary>Int16EnumProperty</summary>
	public ETestInt16 Int16EnumProperty;
	///<summary>Uint16EnumProperty</summary>
	public ETestUint16 Uint16EnumProperty;
	///<summary>Int32EnumProperty</summary>
	public ETestInt32 Int32EnumProperty;
	///<summary>Uint32EnumProperty</summary>
	public ETestUint32 Uint32EnumProperty;
	///<summary>Int64EnumProperty</summary>
	public ETestInt64 Int64EnumProperty;
	///<summary>Uint64EnumProperty</summary>
	public ETestUint64 Uint64EnumProperty;
	///<summary>ArrayOfObjectsProperty</summary>
	public TArray<ATestActorWithProperties> ArrayOfObjectsProperty;
	///<summary>ArrayOfVectorsProperty</summary>
	public TArray<FVector> ArrayOfVectorsProperty;
	///<summary>ArrayOfStructsProperty</summary>
	public TArray<FTestStructWithProperties> ArrayOfStructsProperty;
}
