#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* UFieldSystemMetaDataIteration : Not used anymore, just hiding it right now but will probably be deprecated if not used in the future</summary>
[CppInclude("Field/FieldSystemObjects.h")]
public partial class UFieldSystemMetaDataIteration : UFieldSystemMetaData {
	public static UClass StaticClass() {return default;}
	///<summary>Set the number of iteration type</summary>
	public  UFieldSystemMetaDataIteration SetMetaDataIteration(int Iterations) { return default; }
	///<summary>Number of iterations (WIP)</summary>
	public int Iterations;
}
