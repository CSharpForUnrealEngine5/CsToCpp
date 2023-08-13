namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Used to verify if the generated Python stub is correctly type-hinted (if type hint is enabled). The stub is generated</summary>
[CppInclude("PyTest.h")]
public partial class UPyTestTypeHint : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Check type hinted constants</summary>
	public static string GetStringConst() { return default; }
	///<summary>GetIntConst</summary>
	public static int GetIntConst() { return default; }
	///<summary>Check type hinted properties (setter/getter)</summary>
	public bool BoolProp;
	///<summary>IntProp</summary>
	public int IntProp;
	///<summary>FloatProp</summary>
	public float FloatProp;
	///<summary>EnumProp</summary>
	public EPyTestEnum EnumProp;
	///<summary>StringProp</summary>
	public string StringProp;
	///<summary>NameProp</summary>
	public string NameProp;
	///<summary>TextProp</summary>
	public FText TextProp;
	///<summary>FieldPathProp</summary>
	public object FieldPathProp;
	///<summary>StructProp</summary>
	public FPyTestStruct StructProp;
	///<summary>ObjectProp</summary>
	public UPyTestObject ObjectProp;
	///<summary>StrArrayProp</summary>
	public TArray<string> StrArrayProp;
	///<summary>NameArrayProp</summary>
	public TArray<string> NameArrayProp;
	///<summary>TextArrayProp</summary>
	public TArray<FText> TextArrayProp;
	///<summary>ObjectArrayProp</summary>
	public TArray<UObject> ObjectArrayProp;
	///<summary>SetProp</summary>
	public TSet<string> SetProp;
	///<summary>MapProp</summary>
	public TMap<int,string> MapProp;
	///<summary>DelegateProp</summary>
	public FPyTestDelegate DelegateProp;
	///<summary>MulticastDelegateProp</summary>
	public FPyTestMulticastDelegate MulticastDelegateProp;
	///<summary>Check type hinted methods.</summary>
	public bool CheckBoolTypeHints(bool bParam1,bool bParam2/*=true*/,bool bParam3/*=false*/) { return default; }
	///<summary>CheckIntegerTypeHints</summary>
	public int CheckIntegerTypeHints(byte Param1,int Param2/*=4*/,long Param3/*=5*/) { return default; }
	///<summary>CheckFloatTypeHints</summary>
	public double CheckFloatTypeHints(float Param1,double Param2,float Param3/*=-3.3f*/,double Param4/*=4.4*/) { return default; }
	///<summary>CheckEnumTypeHints</summary>
	public EPyTestEnum CheckEnumTypeHints(EPyTestEnum Param1,EPyTestEnum Param2/*=EPyTestEnum.One*/) { return default; }
	///<summary>CheckStringTypeHints</summary>
	public string CheckStringTypeHints(string Param1,string Param2/*=TEXT("Hi")*/) { return default; }
	///<summary>CheckNameTypeHints</summary>
	public string CheckNameTypeHints(string Param1,string Param2/*=new FName(TEXT("Hi"))*/) { return default; }
	///<summary>CheckTextTypeHints</summary>
	public FText CheckTextTypeHints(FText Param1,FText Param2/*=INVTEXT("Hi")*/) { return default; }
	///<summary>CheckFieldPathTypeHints</summary>
	public object CheckFieldPathTypeHints(object Param1) { return default; }
	///<summary>CheckStructTypeHints</summary>
	public FPyTestStruct CheckStructTypeHints(FPyTestStruct Param1,FPyTestStruct Param2/*=new FPyTestStruct()*/) { return default; }
	///<summary>CheckObjectTypeHints</summary>
	public UPyTestObject CheckObjectTypeHints(UPyTestObject Param1,UPyTestObject Param4/*=nullptr*/) { return default; }
	///<summary>CheckArrayTypeHints</summary>
	public TArray<FText> CheckArrayTypeHints(TArray<string> Param1,TArray<string> Param2,TArray<FText> Param3,TArray<UObject> Param4) { return default; }
	///<summary>CheckSetTypeHints</summary>
	public TSet<string> CheckSetTypeHints(TSet<string> Param1,TSet<string> Param2,TSet<UObject> Param3) { return default; }
	///<summary>CheckMapTypeHints</summary>
	public TMap<string,UObject> CheckMapTypeHints(TMap<int,string> Param1,TMap<int,string> Param2,TMap<int,FText> Param3,TMap<int,UObject> Param4) { return default; }
	///<summary>CheckDelegateTypeHints</summary>
	public FPyTestDelegate CheckDelegateTypeHints(FPyTestDelegate Param1) { return default; }
	///<summary>CheckStaticFunction</summary>
	public static bool CheckStaticFunction(bool Param1,int Param2,double Param3,string Param4) { return default; }
	///<summary>CheckTupleReturnType</summary>
	public static int CheckTupleReturnType(string InOutString) { return default; }
	///<summary>Members to facilitate testing particular Python API.</summary>
	public FPyTestSlateTickDelegate SlateTickDelegate;
}
