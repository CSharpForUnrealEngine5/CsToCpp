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
