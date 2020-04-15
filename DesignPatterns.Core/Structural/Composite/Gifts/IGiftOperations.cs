using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Core.Structural.Gifts
{
    public interface IGiftOperations
    {
        void Add(GiftBase gift);
        void Remove(GiftBase gift);
    }
}
