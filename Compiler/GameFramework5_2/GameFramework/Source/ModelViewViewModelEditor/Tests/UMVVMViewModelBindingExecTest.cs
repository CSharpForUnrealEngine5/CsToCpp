#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tests/MVVMBindingExecuteTest.h")]
public partial class UMVVMViewModelBindingExecTest : UObject {
	///<summary>PropertyA</summary>
	public FMVVMBindingExecTextCounter PropertyA;
	///<summary>PropertyB</summary>
	public TArray<FMVVMBindingExecTextCounter> PropertyB;
	///<summary>PropertyC</summary>
	public int PropertyC;
	///<summary>PropertyD</summary>
	public TArray<int> PropertyD;
	///<summary>PropertyFloat</summary>
	public float PropertyFloat;
	///<summary>PropertyFloatAccessor</summary>
	public float PropertyFloatAccessor;
	///<summary>PropertyDouble</summary>
	public double PropertyDouble;
	///<summary>GetterA</summary>
	public  FMVVMBindingExecTextCounter GetterA() { return default; }
	///<summary>GetterB</summary>
	public  TArray<FMVVMBindingExecTextCounter> GetterB() { return default; }
	///<summary>GetterC</summary>
	public  int GetterC() { return default; }
	///<summary>GetterD</summary>
	public  TArray<int> GetterD() { return default; }
	///<summary>GetterFloat</summary>
	public  float GetterFloat() { return default; }
	///<summary>GetterDouble</summary>
	public  double GetterDouble() { return default; }
	///<summary>SetterA</summary>
	public  void SetterA(FMVVMBindingExecTextCounter Value) {}
	///<summary>SetterB</summary>
	public  void SetterB(TArray<FMVVMBindingExecTextCounter> Value) {}
	///<summary>SetterC</summary>
	public  void SetterC(int Value) {}
	///<summary>SetterD</summary>
	public  void SetterD(TArray<int> Value) {}
	///<summary>SetterFloat</summary>
	public  void SetterFloat(float Value) {}
	///<summary>SetterDouble</summary>
	public  void SetterDouble(double Value) {}
	///<summary>ConversionStructToInt</summary>
	public static int ConversionStructToInt(FMVVMBindingExecTextCounter Value) { return default; }
	///<summary>ConversionConstStructToInt</summary>
	public static int ConversionConstStructToInt(FMVVMBindingExecTextCounter Value) { return default; }
	///<summary>ConversionArrayStructToArrayInt</summary>
	public static TArray<int> ConversionArrayStructToArrayInt(TArray<FMVVMBindingExecTextCounter> Values) { return default; }
	///<summary>ConversionIntToStruct</summary>
	public static FMVVMBindingExecTextCounter ConversionIntToStruct(int Value) { return default; }
	///<summary>ConversionConstIntToStruct</summary>
	public static FMVVMBindingExecTextCounter ConversionConstIntToStruct(int Value) { return default; }
	///<summary>ConversionArrayIntToArrayStruct</summary>
	public static TArray<FMVVMBindingExecTextCounter> ConversionArrayIntToArrayStruct(TArray<int> Values) { return default; }
	///<summary>ConversionIncFloat</summary>
	public static float ConversionIncFloat(float Value) { return default; }
	///<summary>ConversionIncDouble</summary>
	public static float ConversionIncDouble(double Value) { return default; }
}
