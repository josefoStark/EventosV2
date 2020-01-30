using System.Collections.Generic;

namespace EventDomain
{
    public interface IRead
    {
        List<IDatos> GetListEvent();
    }
}
