using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoooooJu.Web.Core.Bus.Proxys
{
    public interface IProxy
    {
        IProxy WithAfterActs(IEnumerable<Action> atcs);
        IProxy WithAfterActsAsync(IEnumerable<Action> atcs);
    }
    public abstract class Proxy : IProxy
    {
        public IProxy WithAfterActs(IEnumerable<Action> atcs)
        {
            foreach (var act in atcs)
            {
                act.Invoke();
            }
            return this;
        }
        public IProxy WithAfterActsAsync(IEnumerable<Action> atcs)
        {
            foreach (var act in atcs)
            {
                Task.Factory.StartNew(act);
            }
            return this;
        }
    }
}
