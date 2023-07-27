#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PyTest.h")]
///<summary>Used to verify if the generated Python stub is correctly type-hinted (if type hint is enabled). The stub is generated</summary>
public partial class UPyTestTypeHint : UObject {
// PyTestTypeHint
	public static string GetStringConst() { return default; }
	public static int GetIntConst() { return default; }
	public bool BoolProp;
	public int IntProp;
	public float FloatProp;
	public EPyTestEnum EnumProp;
	public string StringProp;
	public string NameProp;
	public string TextProp;
	public object FieldPathProp;
	public FPyTestStruct StructProp;
	public UPyTestObject ObjectProp;
	public TArray<string> StrArrayProp;
	public TArray<string> NameArrayProp;
	public TArray<string> TextArrayProp;
	public TArray<UObject> ObjectArrayProp;
	public TSet<string> SetProp;
	public TMap<int,string> MapProp;
	public FPyTestDelegate DelegateProp;
	public FPyTestMulticastDelegate MulticastDelegateProp;
	public  bool CheckBoolTypeHints(bool bParam1,bool bParam2/*=true*/,bool bParam3/*=false*/) { return default; }
	public  int CheckIntegerTypeHints(byte Param1,int Param2/*=4*/,long Param3/*=5*/) { return default; }
	public  double CheckFloatTypeHints(float Param1,double Param2,float Param3/*=-3.3f*/,double Param4/*=4.4*/) { return default; }
	public  EPyTestEnum CheckEnumTypeHints(EPyTestEnum Param1,EPyTestEnum Param2/*=EPyTestEnum.One*/) { return default; }
	public  string CheckStringTypeHints(string Param1,string Param2/*=TEXT("Hi")*/) { return default; }
	public  string CheckNameTypeHints(string Param1,string Param2/*=new FName(TEXT("Hi"))*/) { return default; }
	public  string CheckTextTypeHints(string Param1,string Param2/*=INVTEXT("Hi")*/) { return default; }
	public  object CheckFieldPathTypeHints(object Param1) { return default; }
	public  FPyTestStruct CheckStructTypeHints(FPyTestStruct Param1,FPyTestStruct Param2/*=new FPyTestStruct()*/) { return default; }
	public  UPyTestObject CheckObjectTypeHints(UPyTestObject Param1,UPyTestObject Param4/*=nullptr*/) { return default; }
	public  TArray<string> CheckArrayTypeHints(TArray<string> Param1,TArray<string> Param2,TArray<string> Param3,TArray<UObject> Param4) { return default; }
	public  TSet<string> CheckSetTypeHints(TSet<string> Param1,TSet<string> Param2,TSet<UObject> Param3) { return default; }
	public  TMap<string,UObject> CheckMapTypeHints(TMap<int,string> Param1,TMap<int,string> Param2,TMap<int,string> Param3,TMap<int,UObject> Param4) { return default; }
	public  FPyTestDelegate CheckDelegateTypeHints(FPyTestDelegate Param1) { return default; }
	public static bool CheckStaticFunction(bool Param1,int Param2,double Param3,string Param4) { return default; }
	public static int CheckTupleReturnType(string InOutString) { return default; }
	public FPyTestSlateTickDelegate SlateTickDelegate;
}
