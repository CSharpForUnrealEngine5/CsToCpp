namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PropertyAccess.h")]
///<summary>The various types of property copy</summary>
public enum EPropertyAccessCopyBatch {
	InternalUnbatched=0,
	ExternalUnbatched=1,
	InternalBatched=2,
	ExternalBatched=3,
	Count=4,
}
