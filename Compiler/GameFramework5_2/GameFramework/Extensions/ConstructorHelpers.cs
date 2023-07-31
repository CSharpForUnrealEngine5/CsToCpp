#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;

public partial struct ConstructorHelpers
{
    public struct FObjectFinder<T>
    {
        public FObjectFinder(string path) {
            Object = default;
        }

        public bool Succeeded() { return false; }

        public T Object;
    }

}
