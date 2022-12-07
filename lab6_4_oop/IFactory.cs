using System;
using System.Collections.Generic;
using System.Text;

namespace lab6_4_oop
{
    public interface IFactory<TId>
    {
        TId Id { get; set; }

        void ProcessEntity(TId id);
    }
}
