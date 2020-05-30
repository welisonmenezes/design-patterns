namespace  design_patterns.Patterns.Interator
{
    interface IInterator<T>
    {
        bool hasNext();
        bool hasPrev();
        T current();
        void next();
        void prev();
    }
}