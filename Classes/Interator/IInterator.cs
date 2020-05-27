namespace  design_patterns.Classes.Interator
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