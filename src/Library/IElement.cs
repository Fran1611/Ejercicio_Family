using System;

namespace Library
{
    public interface IElement
    {
        void Accept(IVisitor visitor);
    }
}
